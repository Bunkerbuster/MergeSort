# Merge Sort Algorithm

Source : (Java example) [https://www.youtube.com/watch?v=3j0SWDX4AtU]

![Merge Sort](merge-sort.png)

## Table of Contents
- [About](#about)
- [Usage](#usage)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Example](#example)
- [Contributing](#contributing)
- [License](#license)

## About
This repository contains an implementation of the Merge Sort algorithm in C#. The code includes classes for the Merge Sort algorithm, a helper class for merging, and a controller for demonstrating the algorithm on various arrays.

## Usage
To use the Merge Sort algorithm in your C# project, follow the example provided in the [Example](#example) section.


## Getting Started
## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites

To run this project, you need to have:

- [.NET SDK](https://dotnet.microsoft.com/download) installed.

### Installation

1. Clone this repository to your local machine using your terminal or command prompt:

```bash
git clone https://github.com/Bunkerbuster/MergeSort.git
```

### Example
Here's an example of how to use the Merge Sort algorithm in C#:

    private readonly int[] _UnsortedArray = new[] { 64, 34, 25, 12, 22, 11, 90 };

    private readonly IMergeSortAlgorithm _IMergeSortAlgorithm;

    [HttpGet("PrintSortedArray")]
    public async Task<ActionResult> PrintMergedArray()
    {
        int[] _SortedArray = _IMergeSortAlgorithm.MergeSortArray(_UnsortedArray);

        return Ok(_SortedArray);
    }
  

##Contributing
none



##Licence
Apache-2.0
