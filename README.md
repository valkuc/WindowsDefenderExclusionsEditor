# Windows Defender Exclusions Editor

A simple application, written on the knee, to bulk remove the Windows Defender exclusion list. Should work on Windows 10 out of the box (.NET Framework 4.6). To select multiple items use CTRL or SHIFT buttons.

If you've ever tried to remove 100500 items from Windows Defender exclusions list and gave up after 10 minutes of clicking "Remove" - this is the program for you.

The application will require Administrative access because under the hood it invokes Get-MpPreference and Remove-MpPreference cmdlets.

![app](https://user-images.githubusercontent.com/6421082/227795454-70418c2b-0d5a-4535-8a1b-cce11abd0243.png)
