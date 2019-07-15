# EventSolutions Catalogue System

#### A (*less*) simple inventory system written in *VB.NET :(*

"it kind of works"

> **<u>Installation</u>**
>
> There isn't a packaged executable yet, as the solution is still in (very) early development.
>
> If you want to see what is currently working, you'll need Visual Studio 2015 and a file in `*%appdata%\EventSolutions\userstore\*` called "userstore.txt". An example file has been included in `\source\example_userstore.txt`. Don't try to read the file - It uses my **super advanced** encryption method (which is definitely **very good and secure**)
>
> Once you have the setup completed, you should be able to run the solution and log in with the default credentials, `user` and `password`.

#### <u>To Do:</u> *(Cleared as of 14/7/19)*

- [x] Create *frmDataView.vb*
- [x] Make select universal in *frmDataEntry.vb*
- [ ] Also, fix the quantity
- [x] Bold dates with events in on Calendar view of *frmDataView.vb*
- [x] Create Calendar View panel in *frmDataView.vb*
- [x] Create List View panel in *frmDataView.vb*
- [ ] Add labels under icons in ribbon to increase readability.
- [ ] Style *frmEditUsers.vb* to meet Design Guidelines in EVCS Design Folio.
- [ ] Style *frmAddUserBox.vb* to meet Design Guidelines in EVCS Design Folio.
- [x] Upload Design Guidelines to GitHub Repository as a backup.
- [x] Add 'View Calendar' functionality to *frmDataView.vb*
- [x] Add 'View List' functionality to *frmDataView.vb*
- [ ] Create more secure method of encryption than a +7 cypher.
- [ ] Add the ability to click+drag on the window panels and move them around (this is a problem with the way the windows are designed and not VB or Windows.) This will need to be done for every form.
- [ ] Create search function which returns a list of indexes which correlate to search results in the input list.
- [ ] Add search functionality to *frmDataView.vb* to allow for quicker location of records in both the list and calendar view modes.
- [ ] Add 'Sort by Date (newest)' sorting algorithm
- [ ] Add 'Sort by Date (oldest)' sorting algorithm
- [ ] Add 'Sort by Alphabetical (A-Z)' sorting algorithm
- [ ] Add 'Sort by Alphabetical (Z-A)' sorting algorithm
- [ ] Migrate sorting algorithms to *frmDataView.vb*'s List View
- [ ] Clean up all the (very) messy code
- [ ] Create installer with wizard to set up directory structures, user files, program files, etc.
- [ ] Add "Management" form (Admin only) which will allow for exporting data files with information to email.
- [ ] Send Invoice from hire form once complete? Very, Very long term stretchy goal
- [ ] Fix the ding
- [ ] Fix password error message issue