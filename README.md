# 5-Letter-Words
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/cheaderthecoder/5-Letter-words)
![GitHub top language](https://img.shields.io/github/languages/top/cheaderthecoder/5-Letter-words)
![LICENSE](https://img.shields.io/github/license/cheaderthecoder/5-Letter-words)

A collection of five-letter English words, available in both JSON and TXT format, designed for seamless integration into your project(s). This repository offers an easily accessible list of five-letter words, ideal for word games, educational resources, and various other applications, with an extra c# script to convert txt to json thrown in 😉.


## Table of Contents
- [Usage](https://github.com/cheaderthecoder/5-Letter-words?tab=README.md#Usage)
- [endpoints](https://github.com/cheaderthecoder/5-Letter-words?tab=README.md#Endpoints)
- [Downloads](https://github.com/cheaderthecoder/5-Letter-words?tab=README.md#Download)
- [Examples](https://github.com/cheaderthecoder/5-Letter-words?tab=README.md#Examples)
- [Script](https://github.com/cheaderthecoder/5-Letter-words?tab=README.md#Script)
- [Acknowledgements](https://github.com/cheaderthecoder/5-Letter-words?tab=README.md#Acknowledgements)
- [License](https://github.com/cheaderthecoder/5-Letter-words?tab=README.md#License)


## Usage
You can easily integrate this word list into your projects by accessing either the TXT, JSON endpoints or downlading the files locally. Below are some examples of how to fetch/read and use the word-list endpoint in your application or download and use the file locally, For quick access to relevant links and further details, checkout the [resource page](https://cheaderthecoder.github.io/5-Letter-words/).




## Endpoints
You can access the list of words through the following endpoints:

- **TXT Format:** [words.txt](https://cheaderthecoder.github.io/5-Letter-words/words.txt)
- **JSON Format:** [words.json](https://cheaderthecoder.github.io/5-Letter-words/words.json)

## Downloads
Instead of using a endpoint you can download the files locally at:

- **TXT Format:** [Download words.txt](https://github.com/cheaderthecoder/5-Letter-words/blob/main/words.txt)
- **JSON Format:** [Download words.json](https://github.com/cheaderthecoder/5-Letter-words/blob/main/words.txt)


### Examples
a list of examples of using the word list in your program

#### Python 
Fetching the JSON Data from the endpoint
```python
import requests

url = "https://cheaderthecoder.github.io/5-Letter-words/words.json"
response = requests.get(url)
words = response.json()

print(words[:10])  # Print the first 10 words as an example
```

#### c#
Reading from the TXT file locally

```c#
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Path to the local file containing the 5-letter words
        string filePath = "path/to/your/words.txt";

        // Read all lines from the file into a string array
        string[] words = File.ReadAllLines(filePath);

        // Example: Print the words
        foreach (var word in words)
        {
            Console.WriteLine(wordList[i]);
        }

      Console.ReadKey();
    }
}
```

### JavaScript
Fetching the TXT Data from the endpoint

```js
// URL of the TXT file
const url = 'https://cheaderthecoder.github.io/5-Letter-words/words.txt';

// Fetch the TXT file
fetch(url)
  .then(response => {
    // Check if the response is successful
    if (!response.ok) {
      throw new Error('Status Code: ' + response.statusText);
    }
    return response.text(); // Return the text content
  })
  .then(data => {
    // Split the text data by new lines into an array of words
    const words = data.split('\n').map(word => word.trim());

    // Example: Log the first 10 words
    console.log('First 10 words:', words.slice(0, 10));

    // Log all words (optional)
    // words.forEach(word => console.log(word));
  })
  .catch(error => {
    // Handle errors
    console.error('error:', error);
  });
```


## Script
This script converts a list of words from a text file into a JSON file format. It fetches a text file containing a list of five-letter words from a specified URL, processes the content, and saves it as a JSON file.

#### Overview

    Language: C#
    Dependencies:
        Newtonsoft.Json
        .NET Core or .NET Framework

#### Features

    Fetches data from a remote text file using HttpClient.
    Converts the list of words to a JSON format using JsonConvert.SerializeObject.
    Saves the JSON output to a file named words.json.


## Acknowledgements
A list of Repo's/projects that helped me in someway

 - [Original Repo](https://github.com/charlesreid1/five-letter-words)
 - [Original TXT file](https://github.com/charlesreid1/five-letter-words/blob/master/sgb-words.txt)
 - [Readme.so](https://readme.so/editor)


## License
This project is licensed under the [MIT License](LICENSE.md)
License - see the [LICENSE](LICENSE) file for
details

