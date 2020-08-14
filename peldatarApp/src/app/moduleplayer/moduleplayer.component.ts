import {Component, OnDestroy, OnInit} from '@angular/core';
import {ActivatedRoute, NavigationEnd, Router} from '@angular/router';
import {HttpClient} from '@angular/common/http';
import {Fileitem} from '../fileitem';
// import xml2js from 'xml2js';
import * as xml2js from 'xml2js';
import {Exercise} from '../exercise';


@Component({
  selector: 'app-moduleplayer',
  templateUrl: './moduleplayer.component.html',
  styleUrls: ['./moduleplayer.component.css']
})
export class ModuleplayerComponent implements OnInit, OnDestroy {
  id: number;
  private sub: any;
  public exercises: Array<Exercise>;
  mySubscription: any;
  constructor(private route: ActivatedRoute, private http: HttpClient, private router: Router) {
    this.exercises = new Array<Exercise>();
    // tslint:disable-next-line:only-arrow-functions
    this.router.routeReuseStrategy.shouldReuseRoute = function() {
      return false;
    };

    this.mySubscription = this.router.events.subscribe((event) => {
      if (event instanceof NavigationEnd) {
        // Trick the Router into believing it's last link wasn't previously loaded
        this.router.navigated = false;
      }
    });
  }

  ngOnInit() {
    console.log('oninit');
    this.exercises = new Array<Exercise>();
    this.sub = this.route.params.subscribe(params => {
      this.id = params.id;
      // console.log(this.id);   07
      this.http.get<Array<Fileitem>>('https://api.github.com/repos/kovacsandrasoe/sztf1peldatar/contents/modul' + this.id).subscribe(w => {
        console.log(w);
        for (const asd of w.filter(t => t.name.indexOf('.xml') > 0)) {
          console.log(asd.name);
          this.xmlloader(asd.download_url);
        }
      });
    });
  }

  ngOnDestroy() {
    if (this.mySubscription) {
      this.mySubscription.unsubscribe();
    }
  }

  xmlloader(url: string) {
    let xml = '';
    let json: any;
    this.http.get(url, { responseType: 'text' }).subscribe(z => {
      xml = z;
      const parser = new xml2js.Parser({strict: false, trim: true});
      parser.parseString(xml, (err, result) => {
        json = result;
        const newex = new Exercise();
        newex.title = json.EXERCISE.TITLE[0];
        newex.author = json.EXERCISE.AUTHOR[0]
        newex.level = parseFloat(json.EXERCISE.LEVEL[0]);
        newex.video = json.EXERCISE.VIDEO[0];
        newex.description = json.EXERCISE.DESCRIPTION[0];
        newex.filepath = url;
        newex.solutionpath = url.replace('.xml', '.cs');
        this.exercises.push(newex);
        console.log(newex);
        // console.log(json.EXERCISE.TITLE[0]);
        // const jsonstring = JSON.stringify(json);
        // console.log(jsonstring);
      });
    });
  }
}
