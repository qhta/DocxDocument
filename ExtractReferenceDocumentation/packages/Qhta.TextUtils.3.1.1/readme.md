This is a package of functions to supplement System.Text.

It contains five utility classes:
* **StringListUtils** - utilities for list of string
* **StringsEqualityComparer** - methods for string comparison
* **StringUtils** - various string utility methods
* **TextProcessingUtils.Equivalence.cs** - utility methods for checking text equivalence in text processing
* **UnicodeUtils** - utilities for Unicode block processing

For addition it contains three string comparers:
* **DuplicateAllowingComparer<T>** - list sort comparer used for dictionaries that can contain duplicate keys; T can be any comparable type
* **StringAllowiDuplicateComparer** - singleton class that instance is a DuplicateAllowingComparere<string>
* **StringATergoComparer** - string comparer which compares reversed strings