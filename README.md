# Censorship Against Humanity
> Outline a brief description of your project.
> Live demo [_here_](https://www.example.com). <!-- If you have the project hosted somewhere, include the link here. -->

## Authors
Alesandria, Casey, Eva, Jase, Lindsay, Sage

## Table of Contents
* [General Info](#general-information)
* [Technologies Used](#technologies-used)
* [Features](#features)
* [Screenshots](#screenshots)
* [Setup](#setup)
* [Usage](#usage)
* [Project Status](#project-status)
* [Room for Improvement](#room-for-improvement)
* [Acknowledgements](#acknowledgements)
* [Contact](#contact)
<!-- * [License](#license) -->


## General Information
- Provide general information about your project here.
- What problem does it (intend to) solve?
- What is the purpose of your project?
- Why did you undertake it?
<!-- You don't have to answer all the questions - just the ones relevant to your project. -->


## Technologies Used
- Tech 1 - version 1.0
- Tech 2 - version 2.0
- Tech 3 - version 3.0


## Features
List the ready features here:
- Awesome feature 1
- Awesome feature 2
- Awesome feature 3


## Screenshots
![Example screenshot](./img/screenshot.png)
<!-- If you have screenshots you'd like to share, include them here. -->


## **Setup/Installation Requirements** &#x1F4BB;

<details>
<summary> Initial Setup </summary>

-   Clone this repository to your local machine.
    ```bash
    $ git clone https://github.com/______
    ```
-   Open VS Code (or your IDE of choice).
-   Open the top level directory you just cloned.
</details>
<details>
<summary> Database Setup </summary>

-   Use a MySql RDBMS (like MySql Workbench) to import/upload the cah.sql file and create your database.
-   In your CAH Directory, create a file with the name `appsettings.json` and copy and past the following code into this file:

    <pre><code>{
        "Logging": {
            "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
            }
        },
        "AllowedHosts": "*",
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;cah;uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
        }
    }</code></pre>

-   Use your personal UID and Password for your db connection and make sure you remove the brackets currently in place.

</details>
<!--Download the csv and import into MySQL Workbench
Use Existing Table: change from `efmigrationhistory` to correct table
Click "ok" for Index out of range
Click the wrench &#x1F527;
Switch the drop down to "TEXT" instead of ID
Configure import settings: change field separator to , and line separator to LF
null and NULL = yes -->

<details>
<summary> Finish Setup </summary>

-   In your terminal:

    Change directory (cd) to CAH folder.

    ```bash
    $ dotnet build
    ```

    ```bash
    $ dotnet ef migrations add Initial
    ```

    ```bash
    $ dotnet ef database update
    ```

    ```bash
    $ dotnet run
    ```

    (or `dotnet watch run` to avoid reloading with edits in real time, and have Swagger open).

-   A web page will automatically open in your browser at port 5000 or 5001
</details>

## API

### Query Parameters

-   `______`
-   `______`
-   `______`
-   `______`
-   `______`

<br>

### Endpoints

<details>
<summary><span style="color: rgb(3, 132, 252); font-style: italic;">GET</span></summary>

#### <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/ <br>

#### <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/cah/random<br>

#### Query by parameter:

#### <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks?name={name} <br>

#### <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks?state={state} <br>

#### <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks?type={type} <br>

#### <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks?description={keyword} <br>

<br>For example,<span style="color: rgb(3, 132, 252); font-style: italic;">&nbsp;GET&nbsp;</span> `https://localhost:5001/api/Parks?description=murder` will return the result:

<img src="img/description.jpg" alt="example api response" width="300">
<br>
</details>

<details>
<summary><span style="color: green; font-style: italic;">POST</span></summary>
<br>
<span style="color: green; font-style: italic;">POST</span> /api/parks
<br><br>Create a new Park object in the body in JSON format:
<br><br>
<img src="img/post.jpg" alt="example api response" width="300"><br>
**Check for error messages that might fail validation
<br><br>
</details>

<details>
<summary><span style="color: orange; font-style: italic;">PUT</span></summary>
<br>
<span style="color: orange; font-style: italic;">PUT</span> /api/parks/{parkId}
<br><br>

Edit the details of a Park object.
Always signify the `parkId` of the targeted object <br>For example, to edit Park object with `parkId` 1:<br><span style="color: orange; font-style: italic;">&nbsp;PUT&nbsp;</span> `http://localhost:5000/api/parks/1`:

<img src="img/put.jpg" alt="example api response" width="300">
<br><br>
</details>
<details>
<summary><span style="color: red; font-style: italic;">DELETE</span></summary>
<br>
<span style="color: red; font-style: italic;">DELETE</span> /api/parks/{parkId}
<br><br>

Delete a Park object.
Enter the value of the target card object's `cardId`. For example to delete object with cardId 16:
<br><span style="color: red; font-style: italic;">&nbsp;DELETE&nbsp;</span> `http://localhost:5000/api/___/16`:
<br><br>
<img src="img/delete.jpg" alt="example api response" width="300">

</details>

<br>

## Usage
How does one go about using it?
Provide various use cases and code examples here.

`write-your-code-here`


## Project Status
Project is: _in progress_ / _complete_ / _no longer being worked on_. If you are no longer working on it, provide reasons why.





## Contact

Please contact either<br>
[thataltgirlalesandria@gmail.com](mailto:thataltgirlalesandria@gmail.com?subject=Hello%20Alesandria,&body=Nice%20job!%20), 

[caseyfhill1@gmail.com](mailto:caseyfhill1@gmail.com?subject=Hello%20Casey,&body=Nice%20job!%20), 

[eva.j.kemp@gmail.com](mailto:eva.j.kemp@gmail.com?subject=Hello%20Eva,&body=Nice%20job!%20), 

[jase.grable@gmail.com](mailto:jase.grable@gmail.com.com?subject=Hello%20Jase,&body=Nice%20job!%20)

with any the following:

-   Found bugs &#x1F41E;
-   General Questions



<details>
<summary>Copyright (c) 2023 Alesandria, Casey, Eva, Jase, Lindsay, Sage</summary>
<br>
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
</detalis>