import { Component, OnInit } from '@angular/core';
import { Member } from '../_models/member.model';
import { MembersService } from '../_services/members.service';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {
  members: Member[];
  constructor(private membersService: MembersService) { }

  ngOnInit(): void {
    this.membersService.getMembers().subscribe(response => {
      this.members = response;
    })
  }

}
