import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import {HttpClient} from '@angular/common/http';
import {Fileitem} from '../fileitem';
import xml2js from 'xml2js';

@Component({
  selector: 'app-moduleplayer',
  templateUrl: './moduleplayer.component.html',
  styleUrls: ['./moduleplayer.component.css']
})
export class ModuleplayerComponent implements OnInit {
  id: number;
  private sub: any;
  constructor(private route: ActivatedRoute, private http: HttpClient) { }

  ngOnInit() {
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

  xmlloader(url: string) {
    let xml = '';
    let json = '';
    this.http.get(url, { responseType: 'text' }).subscribe(z => {
      xml = z;
      const parser = new xml2js.Parser({strict: false, trim: true});
      parser.parseString(xml, (err, result) => {
        json = result;
        console.log(json);
        const jsonstring = JSON.stringify(json);
        console.log(jsonstring);
      });
    });
  }
}
