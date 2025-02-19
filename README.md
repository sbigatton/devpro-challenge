# Dev.Pro challenge

## Task 1: Logger

Navigate to Helpers -> Logger.cs class file.

## Task 1.1: Test scenarios

### Verify success log: 
Logger.LogMessage("validFilePath.txt", "Log message", "LOG");
Logger.LogMessage("validFilePath.txt", "Warn message", "WARN");

Expected: New file is created with 2 records.

### Verify success log with existing file:
Pre condition: validFilePath.txt must exist in path.
Logger.LogMessage("validFilePath.txt", "Log message", "LOG");

Expected: File is found, write a new line at the end and previous records in scenario 1 are displayed.

### Verify empty message
Logger.LogMessage("validFilePath.txt", "", "LOG");
or
Logger.LogMessage("validFilePath.txt", string.empty, "LOG");

Expected: "[yyyy-MM-dd HH:mm:ss] [LOG]" line without message is displayed

### Verify long messages:
Logger.LogMessage(filePath, new string('t', 500), "LOG");
Expected: "[yyyy-MM-dd HH:mm:ss] [LOG] ttttttt" (500 t in message)

### Verify file concurrency:
File is tried to be accessed to be written in parallel. 

Expected: File is written in same order is accessed.

Notes: 
- Could be invalid filepath or not existing file error but File.AppendText() taken approach is going create the file if not exists.

## Task 2: Inventory Management

Navigate to Models -> Inventory.cs and Product class files.

Usage: 
1) Initialize Inventory class.
2) Use AddProduct to add products.
3) Use GetSortedProducts(string sort_key, bool ascending)