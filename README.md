# Censorship Against Humanity
> Censorship Against Humanity is a censored version of Cards Against Humanity. In its current form, it's a one person game. When the user flips over the start game card, a random black and white card are generated. The user can then draw up to four more cards, for a total "hand" of five cards. The user can select a winning card and start another game. 

## Authors
Alesandria Wild, Casey Hill, Eva Kemp, Jase Grable, Lindsay Warr, Sage Paden

## Table of Contents
* [General Info](#general-information)
* [Technologies Used](#technologies-used)
* [Setup](#setup)
* [Project Status](#project-status)
* [Known Bugs](#known-bugs)
* [Acknowledgements](#acknowledgements)
* [Contact](#contact)
* [License](#license)

## General Information
- The game was created for Team Week 2 at Epicodus. It was built mainly with C# and .NET, with additional JavaScript for functionality.

## Technologies Used
- C#/.NET
- AspNet Core
- JavaScript
- Git
- GitHub
- Microsoft Entity Framework
- Razor
- MySql
- EFCore Design
- EFCore Migration
- MySql Workbench
- Markdown

## **Setup/Installation Requirements** &#x1F4BB;

<details>
<summary> Initial Setup </summary>

-   Clone this repository to your local machine.
    ```bash
    $ git clone https://github.com/ThatAltGirlAlesandria/CAH2.0.git
    ```
-   Open VS Code (or your IDE of choice).
-   Open the top level directory `CAH`
</details>
<details>
<summary> Database Setup </summary>

-   In the `CAH` Directory, create a file with the name `appsettings.json` and copy and paste the following code into this file:

    <pre><code>{
        "Logging": {
            "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
            }
        },
        "AllowedHosts": "*",
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=cahdb;uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
        }
    }</code></pre>

-   Use your personal UID and Password for your db connection and make sure you remove the brackets currently in place.
-   Run the following commands 
```bash 
dotnet ef migrations add InitialMigration
```
```bash 
dotnet ef database update
```

</details>

<details>
<summary> Finish Setup </summary>

-   In your terminal:

    Change directory (cd) to CAH folder.

    ```bash
    $ dotnet build
    ```

    ```bash
    $ dotnet run
    ```

    (or `dotnet watch run` to avoid reloading with edits in real time).

-   A web page will automatically open in your browser at port 5000 or 5001.
    -   If the page does not automatically open, check your project's terminal and click the localhost port link or copy and paste the following into your browser: `https://localhost:5001/` or `https://localhost:5001/` depending on what port is being used.
-   Add your admin password to authorize the program to run.
</details>

## Project Status
Project is mostly complete. There is hope in the future to make the application into a multi-player game. &#x1F46F;

## Known Bugs
- Some CSS styling not functioning as expected and may present accessibility issues.
- There are some typos present on the cards.

## Acknowledgements
We would like to acknowledge the creative influence of the renowned card game, Cards Against Humanity, which served as an inspiration for the development of our app. We do not claim any ownership or affiliation with the creators of the original game.

## Contact
Please contact either<br>
&#x1F47E; [thataltgirlalesandria@gmail.com](mailto:thataltgirlalesandria@gmail.com?subject=Hello%20Alesandria,&body=Nice%20job!%20) &#x1F47E; 

&#x1F47B; [caseyfhill1@gmail.com](mailto:caseyfhill1@gmail.com?subject=Hello%20Casey,&body=Nice%20job!%20) &#x1F480;

&#x1F483; [eva.j.kemp@gmail.com](mailto:eva.j.kemp@gmail.com?subject=Hello%20Eva,&body=Nice%20job!%20) &#x1F483;

&#x1F341; [jase.grable@gmail.com](mailto:jase.grable@gmail.com.com?subject=Hello%20Jase,&body=Nice%20job!%20) &#x1F341;

&#x1F981; [iamalion@gmail.com](mailto:iamalion@gmail.com.com?subject=Hello%20Lindsay,&body=Nice%20job!%20) &#x1F981;

&#x1F448; &#x1F920; &#x1F449; [sagepaden@gmail.com](mailto:sagepaden@gmail.com.com?subject=Hello%20Sage,&body=Nice%20job!%20) &#x1F448;  &#x1F920; &#x1F449;

with any the following:

-   Found bugs &#x1F41E;
-   General questions &#x2753;
-   Concerns about particular cards &#x1F920;



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