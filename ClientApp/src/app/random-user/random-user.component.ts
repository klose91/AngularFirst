import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-random-user',
  templateUrl: './random-user.component.html'
})
export class RandomUserCompnent {
  public users: User[];
  public httpClient: HttpClient;
  public numberOfUsers: number;

  constructor(http: HttpClient) {
    this.httpClient = http;
  }

  public getRandomUser(): void {
    this.httpClient.get<RandomUsers>(`https://randomuser.me/api?results=${this.numberOfUsers}`).subscribe(res => {
      this.users = res.results;
    }, err => console.error(err));
  }

  public getUserSex(gender: string): string {
    return gender == 'male' ? 'mars' : (gender == 'female' ? 'venus' : 'neuter');
  }
}

export interface Name {
  title: string;
  first: string;
  last: string;
}

export interface Coordinates {
  latitude: string;
  longitude: string;
}

export interface Timezone {
  offset: string;
  description: string;
}

export interface Location {
  street: string;
  city: string;
  state: string;
  postcode: string;
  coordinates: Coordinates;
  timezone: Timezone;
}

export interface Login {
  uuid: string;
  username: string;
  password: string;
  salt: string;
  md5: string;
  sha1: string;
  sha256: string;
}

export interface Dob {
  date: Date;
  age: number;
}

export interface Registered {
  date: Date;
  age: number;
}

export interface Id {
  name: string;
  value: string;
}

export interface Picture {
  large: string;
  medium: string;
  thumbnail: string;
}

export interface User {
  gender: string;
  name: Name;
  location: Location;
  email: string;
  login: Login;
  dob: Dob;
  registered: Registered;
  phone: string;
  cell: string;
  id: Id;
  picture: Picture;
  nat: string;
}

export interface Info {
  seed: string;
  results: number;
  page: number;
  version: string;
}

export interface RandomUsers {
  results: User[];
  info: Info;
}
