import { AlterifyService } from './../_services/alterify.service';
import { AuthService } from './../_services/auth.service';
import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class AuthGuard implements CanActivate {

    constructor(private authService: AuthService, private router: Router, private alertify: AlterifyService) {}

    canActivate(): Observable<boolean> | Promise<boolean> | boolean {

        if (this.authService.loggedIn()) {
            return true;
        }
        this.alertify.error('يجب عليك تسجيل الدخول اولاً');
        this.router.navigate(['/home']);
        return false;

    }
}
