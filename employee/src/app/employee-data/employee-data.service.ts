import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable,  of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { environment } from '../../environments/environment'
import { utils } from '../utiles/utiles'
import { trapError} from '../catcherrors';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({ providedIn: 'root' })
export class EmployeeDataService {
  private _utils:utils = new utils();
  private url = environment.url;
  private _result: any;
  constructor(
    private http: HttpClient) { }

    get (): Observable<any>{
        const _utiles = new trapError();
        return this.http.get<any>(environment.url)
        .pipe(
          tap(pitos => _utiles.log('mmmmm')),
          catchError(_utiles.handleError('nnnn', null))
        );
    }
    getById (args:string): Observable<any>{
      const _utiles = new trapError();
      let url = environment.url + "/" + args;
      return this.http.get<any>(url)
      .pipe(
        tap(pitos => _utiles.log('mmmmm')),
        catchError(_utiles.handleError('nnnn', null))
      );
  }

}
