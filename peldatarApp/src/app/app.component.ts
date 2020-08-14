import { Component } from '@angular/core';
import {HttpClient} from '@angular/common/http';
// import * as xml2js from 'xml2js';
import xml2js from 'xml2js';
import {Observable} from 'rxjs';
import {Module} from './module';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'peldatarApp';
  public modules: Array<Module>;
  public jsonstring: string;
  constructor(public http: HttpClient) {
    this.parse();
    this.modules = new Array<Module>();
  }

  parse() {
    let xml = '';
    let json = '';
    this.http.get('https://kovacsandrasoe.github.io/sztf1peldatar/modules.xml', { responseType: 'text' }).subscribe(z => {
      xml = z;
      const parser = new xml2js.Parser({ strict: false, trim: true });
      parser.parseString(xml, (err, result) => {
        json = result;
        this.jsonstring = JSON.stringify(json);
        // console.log(this.jsonstring);
      });
      const obj = JSON.parse(JSON.stringify(json));
      // console.log(obj.MODULES.MODULE);
      for (const val of obj.MODULES.MODULE) {
        console.log(val);
        const mod = new Module();
        mod.title = val.TITLE[0];
        mod.id = val.ID[0];
        this.modules.push(mod);
      }
      console.log(this.modules);
    });
  }
}
