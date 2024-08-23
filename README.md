# 5-Letter-Words

![GitHub top language](https://img.shields.io/github/languages/top/cheaderthecoder/tic-tac-toe)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/cheaderthecoder/tic-tac-toe)
![LICENSE](https://img.shields.io/github/license/cheaderthecoder/tic-tac-toe)

A collection of 5-letter words from the English language, available in both JSON and TXT formats for use in your projects. This repository provides convenient access to a list of five-letter words, which can be useful for word games, educational tools, or other applications.

## Table of Contents
- [endpoints](https://github.com/cheaderthecoder/5-Letter-words?tab=README.md#Endpoints)
- [Usage](https://github.com/cheaderthecoder/5-Letter-words?tab=README.md#Usage)
- [Examples](https://github.com/cheaderthecoder/5-Letter-words?tab=README.md#Examples)
- [Sources](https://github.com/cheaderthecoder/5-Letter-words?tab=README.md#sources)
- [License](https://github.com/cheaderthecoder/5-Letter-words?tab=README.md#license)

## Endpoints
You can access the list of words through the following endpoints:

- **TXT Format:** [words.txt](https://cheaderthecoder.github.io/5-Letter-words/words.txt)
- **JSON Format:** [words.json](https://cheaderthecoder.github.io/5-Letter-words/words.json)

or download the files locally at:
- **TXT Format:** [Download words.txt](https://github.com/cheaderthecoder/5-Letter-words/blob/main/words.txt)
- **JSON Format:** [Download words.json](https://github.com/cheaderthecoder/5-Letter-words/blob/main/words.txt)


## Usage
You can easily integrate this word list into your projects by accessing either the TXT or JSON endpoints. Below are some examples of how to fetch/read and use the word-list in your application or download it and load it from a file locally

### Examples

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

