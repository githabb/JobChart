import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
  
@Injectable()
export class HttpService{
  
    constructor(private http: HttpClient){ }
      
    getChartList(){
        return this.http.get('http://localhost:63342/api/chart')
    }

    getLineData(){
        return this.http.get('http://localhost:63342/api/line')
    }

    getPieData(){
        return this.http.get('http://localhost:63342/api/pie')
    }

    getSplineData(){
        return this.http.get('http://localhost:63342/api/spline')
    }

    getPolarData(){
        return this.http.get('http://localhost:63342/api/polar')
    }

    getData(chartType){
        switch (chartType) {
            case 'Line':
                return this.getLineData();

            case 'Pie':
                return this.getPieData();

            case 'Spline':
                return this.getSplineData();

            case 'Polar':
                return this.getPolarData();

            default:
                return null;
        }
    }
}