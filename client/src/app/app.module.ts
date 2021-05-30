import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import{HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import{BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component'
import{FormsModule, ReactiveFormsModule} from '@angular/forms'
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { MemberDetailsComponent } from './members/member-details/member-details.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { ToastrModule } from 'ngx-toastr';
import { SharedModule } from './_modules/shared.module';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { MemberCardComponent } from './members/member-card/member-card.component';
import{TabsModule} from 'ngx-bootstrap/tabs';
import { MemberEditComponent } from './members/member-edit/member-edit.component';
import { NgxSpinnerModule } from 'ngx-spinner';
import { LoadingInterceptor } from './_interceptor/loading.interceptor';
import { PhotoEditorComponent } from './members/photo-editor/photo-editor.component';
import { TextInputComponent } from './_forms/text-input/text-input.component';
import { DateInputComponent } from './_forms/date-input/date-input.component';
import { JwtInterceptor } from './_interceptor/jwt.interceptor';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { ErrorInterceptor } from './_interceptor/error.interceptor';
import { MemberMessagesComponent } from './members/member-messages/member-messages.component';


@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    RegisterComponent,
    MemberDetailsComponent,
    MemberListComponent,
    ListsComponent,
    MessagesComponent,
    TestErrorsComponent,
    MemberCardComponent,
    MemberEditComponent,
    PhotoEditorComponent,
    TextInputComponent,
    DateInputComponent,
    NotFoundComponent,
    ServerErrorComponent,
    MemberMessagesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    SharedModule,
    BsDropdownModule,
    TabsModule.forRoot(),
    NgxSpinnerModule
   

  ],
  providers: [
    {provide:HTTP_INTERCEPTORS,useClass:JwtInterceptor,multi:true},
    {provide:HTTP_INTERCEPTORS,useClass:LoadingInterceptor,multi:true},
    {provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true}

  ],
  bootstrap: [AppComponent]
})
export class AppModule {
  title='Dating app';

 }