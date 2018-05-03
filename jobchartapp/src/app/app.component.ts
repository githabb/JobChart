import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';
import { ChartModel } from './chart.model';
import { LineModel } from './line.model';
import { PieModel } from './pie.model';
import { SplineModel } from './spline.model';
import { Chart } from 'angular-highcharts';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [HttpService]
})
export class AppComponent implements OnInit {
  title = 'Job Chart App';

  lineChart: Chart;
  pieChart: Chart;
  splineChart: Chart;

  loading: boolean = false;
  loaded: boolean = false;

  charts: ChartModel[] = [];
  lines: LineModel[] = [];
  pies: PieModel[] = [];
  splines: SplineModel[] = [];

  constructor(private httpService: HttpService){ 
  }
      
  ngOnInit(){   
    
    this.httpService.getChartList().subscribe(data => this.charts = <ChartModel[]>data);
    
    this.httpService.getLineData().subscribe(data => this.lines = <LineModel[]>data);
    this.httpService.getPieData().subscribe(data => this.pies = <PieModel[]>data);
    this.httpService.getSplineData().subscribe(data => this.splines = <SplineModel[]>data);

    this.init();
  }

  loadData() {    
    this.loading = true;
    this.lineChart.addSerie({
      name: 'Line',
      data: this.lines.map(o => o.value)
    });

    
    let pieData = [];
    for(var i of this.pies) {
      pieData.push({name: i.month, y: i.percent});
    }
    
    let splineXData = [];
    let splineYData = [];
    for(var n of this.splines) {
      splineXData.push({y: n.x, name: n.letter});
      splineYData.push({y: n.y, name: n.letter});
    }

    this.pieChart.addSerie({
      name: 'Months',
      data: pieData
    });

    this.splineChart.addSerie({
      name: 'X',
      data: splineXData
    });

    this.splineChart.addSerie({
      name: 'Y',
      data: splineYData
    });

    this.loaded = true;
    this.loading = false;        
  }
    

  isLoaded() : boolean {
    return this.loaded || this.loading;
  }

  init() {
    
    this.lineChart = this.createChart('line');
    this.pieChart = this.createChart('pie');
    this.splineChart = this.createSplineChart();
  }

  createChart(chartType): Chart {
    return new Chart({
      chart: {
        type: chartType
      },
      title: {
        text: chartType + ' chart'
      },
      credits: {
        enabled: false
      },
      series: []
    });
  }

  createSplineChart(): Chart {
    let result = this.createChart('spline');

    result.options.yAxis = {
      title: {
          text: 'Price'
      },
      labels: {
          formatter: function () {
              return '$' + this.value;
          }
      }
    };
    return result;
  }
  
}