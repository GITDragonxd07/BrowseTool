
# BrowseTool

BrowseTool is a simple application used for easier web authentication



## Usage

Launch BrowseTool.exe with these arguments

```
"Target Web Adress" (Close on match) "Target Phrase"
```
## Example

For example, we want to close the tool when we enter a certian phrase on google

```
"https://www.google.com" True "q=helloworld"
```

These arguments will launch the google website and wait untill the URL contains "q=helloworld"
