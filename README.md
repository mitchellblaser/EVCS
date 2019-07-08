# EventSolutions Catalogue System

#### A (*less*) simple inventory system written in *VB.NET :(*

(shut up, it works, okay?)

> **<u>Installation</u>**
>
> There isn't a packaged executable yet, as the solution is still in (very) early development.
>
> If you want to see what is currently working, you'll need Visual Studio 2015 and a file in `*%appdata%\EventSolutions\userstore\*` called "userstore.txt". An example file has been included in `\source\example_userstore.txt`. Don't try to read the file - It uses my **super advanced** encryption method (its actually just a +7 cypher but that's our little secret okay?)
>
> Once you have the setup completed, you should be able to run the solution and log in with the default credentials, `user` and `password`.

#### <u>To Do:</u> *(Cleared as of 8/7/19)*

- [x] Add Delete User functionality to *frmEditUsers.vb*
- [ ] Add Check to ensure the same username doesn't get used twice to *frmEditUsers.vb*
- [ ] Add synchronized scrolling functionality to *frmEditUsers.vb*
- [x] Add synchronized selection functionality to *frmEditUsers.vb*
- [ ] Create *frmDataView.vb*
- [ ] Create Calendar View panel in *frmDataView.vb*
- [ ] Create List View panel in *frmDataView.vb*
- [ ] Migrate Ribbon from *frmDataEntry.vb* to *frmDataView.vb* (create two copies)
- [ ] Add labels under icons in ribbon to increase readability.
- [ ] Style *frmEditUsers.vb* to meet Design Guidelines in EVCS Design Folio.
- [ ] Style *frmAddUserBox.vb* to meet Design Guidelines in EVCS Design Folio.
- [ ] Upload Design Guidelines to GitHub Repository as a backup.
- [ ] Add 'New Client' functionality to *frmDataEntry.vb*
- [ ] Add 'New Equipment' functionality to *frmDataEntry.vb*
- [ ] Add 'New Hire' functionality to *frmDataEntry.vb*
- [ ] Add File In/Out functionality to write out new data and read in existing data records to *frmDataEntry.vb*
- [ ] Add 'View Calendar' functionality to *frmDataView.vb*
- [ ] Add 'View List' functionality to *frmDataView.vb*
- [ ] Add File In functionality to read in data records created in *frmDataEntry.vb*
- [ ] Migrate Encryption/Decryption method to *frmDataEntry.vb*
- [ ] Migrate Encryption/Decryption method to *frmDataView.vb*
- [ ] Create more secure method of encryption than a +7 cypher.
- [ ] Add the ability to click+drag on the window panels and move them around (this is a problem with the way the windows are designed and not VB or Windows.) This will need to be done for every form.
- [ ] Create search function which returns a list of indexes which correlate to search results in the input list.
- [ ] Add search functionality to *frmDataEntry.vb* to allow for quicker modification of records.
- [ ] Add search functionality to *frmDataView.vb* to allow for quicker location of records in both the list and calendar view modes.
- [ ] Add 'Sort by Date (newest)' sorting algorithm
- [ ] Add 'Sort by Date (oldest)' sorting algorithm
- [ ] Add 'Sort by Alphabetical (A-Z)' sorting algorithm
- [ ] Add 'Sort by Alphabetical (Z-A)' sorting algorithm
- [ ] Migrate sorting algorithms to *frmDataView.vb*'s List View