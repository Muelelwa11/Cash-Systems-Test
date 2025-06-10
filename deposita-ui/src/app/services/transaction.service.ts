import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Transaction {
  id?: number;
  description: string;
  amount: number;
  date: string;
}

@Injectable({
  providedIn: 'root'
})
export class TransactionService {
  private apiUrl = 'https://localhost:5001/api/transaction';

  constructor(private http: HttpClient) { }

  getTransactions(): Observable<Transaction[]> {
    return this.http.get<Transaction[]>(this.apiUrl);
  }

  addTransaction(transaction: Transaction): Observable<Transaction> {
    return this.http.post<Transaction>(this.apiUrl, transaction);
  }

  updateTransaction(transaction: Transaction): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/${transaction.id}`, transaction);
  }

  deleteTransaction(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}