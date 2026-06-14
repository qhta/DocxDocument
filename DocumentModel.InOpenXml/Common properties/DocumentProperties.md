Document properties are properties that describe the document as a whole, such as the title, author, or creation date. 
These properties can be used to provide metadata about the document, which can be useful for organizing and searching for documents.

# Types of document properties

There are two types of document properties: built-in properties and custom properties.
Built-in properties are predefined properties that have specific names and value types, while custom properties are user-defined properties that can have any name and value type.

Built-in properties are divided into three categories: core properties, content properties, and statistic properties.
* Core properties are properties that are essential to the document, such as the title, author, or creation date. In OpenXml document they are stored in docProps/core.xml file.
* Content properties are specific to the content of the document, such as template, presentation format, or application name. In OpenXml document they are stored in docProps/app.xml file.
* Statistic properties are properties that provide statistical information about the document, such as the number of pages, words, or characters. In OpenXml document they are stored in docProps/app.xml file.

Core properties include:
- Title: The title of the document.
- Subject: The subject of the document.
- Creator: The creator of the document.
- LastModifiedBy: The last person who modified the document.
- Keywords: The keywords associated with the document.
- Description: A description of the document.
- Created: The date and time when the document was created.
- Modified: The date and time when the document was last modified.
- LastPrinted: The date and time when the document was last printed.
- Category: The category of the document.
- Identifier: A unique identifier for the document.
- ContentType: The type of content in the document.
- Version: The version number of the document.
- ContentStatus: The status of the content in the document.
- Revision: The revision number of the document.

Revision is of integer type. It should be incremented each time the document is modified and saved. This allows for tracking the number of revisions made to the document.
Created, Modified and LastPrinted are of DateTime type and should be updated accordingly. All other core properties are of string type and can be used in free-form.

Content properties include:
- Application: The name of the application used to create the document.
- AppVersion: The version of the application used to create the document.
- Company: The company associated with the document.
- Manager: The manager associated with the document.
- DigitalSignature: A hexadecimal string that represents the digital signature of the signed document.
- DocumentSecurity: Encoded representation of the security settings of the document.
- HyperlinkBase: The base URL for hyperlinks in the document.
- HyperlinksChanged: A boolean value that indicates whether the hyperlinks in the document have changed.
- HyperlinkList: A list of hyperlinks that were in the document when it was last saved.
- LinksUpToDate: A boolean value that indicates whether the links in the document are up to date.
- PresentationFormat: The presentation format of the document.
- ScaleCrop: A boolean value that indicates whether the document is scaled to fit the page.
- SharedDoc: A boolean value that indicates whether the document is shared.
- Template: The name of the template used to create the document.
- TitlesOfParts: A list of titles of the parts in the document. These parts are not document parts but conceptual representations of document sections.
- HeadingPairs: A list of pairs of headings and their corresponding counts in the document. This is used to provide a summary of the document's structure.

Note that some of the content property types are compound types, such as HyperlinkList and TitlesOfParts, which are lists of strings. The HeadingPairs property is a list of pairs of strings and integers, where the string represents the heading and the integer represents the count of that heading in the document.

Statistic properties include:
- Pages: The number of pages in the document.
- Words: The number of words in the document.
- Characters: The number of characters in the document.
- Lines: The number of lines in the document.
- Paragraphs: The number of paragraphs in the document.
- CharactersWithSpaces: The number of characters in the document, including spaces.
- Slides: The number of slides in the document (for presentation documents).
- Notes: The number of notes in the document (for presentation documents).
- HiddenSlides: The number of hidden slides in the document (for presentation documents).
- MultimediaClips: The number of multimedia clips in the document (for presentation documents).
- TotalTime: The total editing time for the document, in minutes.

Custom properties are user-defined properties that can have any name and value type. 
They can be used to store additional metadata about the document that is not covered by the built-in properties.
Each custom property has the following properties:
- PropertyId: A unique identifier for the custom property, which is used to reference the custom property within the document. This is typically an integer value that is incremented for each new custom property added to the document. The first property should have PropertyId = 2.
- Name: The name of the custom property.
- Value: The value of the custom property.
- Type: The data type of the custom property value which can be one the following types: string, integer, boolean, date and time..
- FormatId: A unique identifier for the custom property, which is always "D5CDD505-2E9C-101B-9397-08002B2CF9AE".
- LinkTarget: An optional property that specifies a target for the custom property, such as a hyperlink or a reference to another part of the document. This can be used to create relationships between custom properties and other elements in the document.

# Implementation in OpenXml

Core properties are stored in the docProps/core.xml file, content properties and statistic properties are stored in the docProps/app.xml file, and custom properties are stored in the docProps/custom.xml file.

A **core.xml** file is illustrated by this example: 
```
<cp:coreProperties 
    xmlns:cp="http://schemas.openxmlformats.org/package/2006/metadata/core-properties" 
    xmlns:dc="http://purl.org/dc/elements/1.1/" 
    xmlns:dcterms="http://purl.org/dc/terms/" 
    xmlns:dcmitype="http://purl.org/dc/dcmitype/" 
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <dc:title/>
  <dc:subject/>
  <dc:creator>rex</dc:creator>
  <cp:keywords/>
  <cp:lastModifiedBy>Jarosław Kuchta</cp:lastModifiedBy>
  <cp:revision>25</cp:revision>
  <dcterms:created xsi:type="dcterms:W3CDTF">2023-04-19T18:03:00Z</dcterms:created>
  <dcterms:modified xsi:type="dcterms:W3CDTF">2024-07-10T14:40:00Z</dcterms:modified>
</cp:coreProperties>
```

Sample **app.xml** file:
```
<Properties 
    xmlns="http://schemas.openxmlformats.org/officeDocument/2006/extended-properties" 
    xmlns:vt="http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes">
  <Template>Normal.dotm</Template>
<TotalTime>140</TotalTime>
  <Pages>1</Pages>
  <Words>31811</Words>
  <Characters>190866</Characters>
  <Application>Microsoft Office Word</Application>
  <DocSecurity>0</DocSecurity>
  <Lines>1590</Lines>
  <Paragraphs>444</Paragraphs>
  <ScaleCrop>false</ScaleCrop>
  <HeadingPairs>
    <vt:vector size="2" baseType="variant">
      <vt:variant>
        <vt:lpstr>Tytuł</vt:lpstr>
      </vt:variant>
      <vt:variant>
        <vt:i4>1</vt:i4>
      </vt:variant>
    </vt:vector>
  </HeadingPairs>
  <TitlesOfParts>
    <vt:vector size="1" baseType="lpstr">
     <vt:lpstr/>
    </vt:vector>
  </TitlesOfParts>
  <Company/>
  <LinksUpToDate>false</LinksUpToDate>
  <CharactersWithSpaces>222233</CharactersWithSpaces>
  <SharedDoc>false</SharedDoc>
  <HyperlinksChanged>false</HyperlinksChanged>
  <AppVersion>16.0000</AppVersion>
</Properties>
```

Example of **custom.xml** file:
```
<op:Properties
    xmlns:vt="http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes" 
    xmlns:op="http://schemas.openxmlformats.org/officeDocument/2006/custom-properties">
  <op:property fmtid="{D5CDD505-2E9C-101B-9397-08002B2CF9AE}" pid="2" name="SampleBoolean">
    <vt:bool>false</vt:bool>
  </op:property>
  <op:property fmtid="{D5CDD505-2E9C-101B-9397-08002B2CF9AE}" pid="3" name="SampleDate">
    <vt:filetime>2026-06-12T22:10:49</vt:filetime>
  </op:property>
  <op:property fmtid="{D5CDD505-2E9C-101B-9397-08002B2CF9AE}" pid="4" name="CustomTitle">
    <vt:lpwstr>Updated Title</vt:lpwstr>
  </op:property>
</op:Properties>
```

Accessing and modifying document properties can be done using the OpenXml SDK, 
which provides classes and methods for working with these properties. 
The OpenXmlclasses are:
* **CoreFilePropertiesPart**: It provides methods for accessing and modifying the core properties.
* **ExtendedFilePropertiesPart**: It provides methods for accessing and modifying the content properties and statistic properties.
* **CustomFilePropertiesPart**: It provides methods for accessing and modifying the custom properties.

# Implementation in DocumentModel.InOpenXml


There are four classes in DocumentModel.InOpenXml that represent the document properties:
**CoreProperties**, **ContentProperties**, **StatisticProperties** and **CustomProperties**. 
Three first of them directly declare public properties, which represent the built-in properties, 
while **CustomProperties** class provides methods for working with a collection of custom properties, 
such as adding, retrieving, updating, and deleting custom properties.

## CoreProperties, ContentProperties and StatisticProperties classes
**CoreProperties**, **ContentProperties** and **StatisticProperties** classes are wrappers around the corresponding OpenXml parts, 
which means that they provide a higher-level interface for working with the properties, 
while still allowing access to the underlying OpenXml parts if needed.

**ContentProperties** and **StatisticProperties** classes have a reference a root element of the **ExtendedFilePropertiesPart**, 
which is declared as **_UpdatedElement** property of **DocumentFormat.OpenXml.ExtendedProperties.Properties** type.
This property allows loading and updating data in the **ExtendedFilePropertiesPart**.

When attaching **ContentProperties** or **StatisticProperties** to the document, 
the corresponding part is created and the root element is loaded into the **_UpdatedElement** property. 
When detaching these properties from the document, the **_UpdatedElement** property is set to null.

**CoreProperties** class does not have a reference to the root element of the **CoreFilePropertiesPart**, 
but to the **PackageProperties** interface, which is provided by **CoreFilePropertiesPart**.
This is because the **CorePropertiePart** is managed at the package level, 
and the properties are accessed through the **PackageProperties** interface,
and allows for accessing the core properties directly without the need to load the entire XML structure of the part.

## BaseBuiltInProperties and KnownProperties classes

**CoreProperties**, **ContentProperties** and **StatisticProperties** classes have common base class called **BaseBuiltInProperties**, 
which provides common functionality for working with **CorePropertiesPart** and **ExtendedPropertiesParts** 
while providing a consistent interface for accessing and modifying the sets properties.

These sets of properties are declared as **KnownProperties**, which are specific for each built-in properties class.
Each of **CoreProperties**, **ContentProperties** and **StatisticProperties** classes have their own set of known properties, 
which are passed to the base class **BaseBuiltInProperties** during initialization.

The **KnownProperties** have methods for discovering the properties of the given type
and registering them in a dictionary, which allows for easy access to the properties by their names.
All public properties which have a write accesor and have no **NotMapped** attribute declared 
are automatically registered as known properties.

**BaseBuiltInProperties** class provides methods for getting and setting the values of the properties,
and accessing them by their names. 
It also provides an enumerator, which allows for iterating over all the properties in the set, which have non-null values.

## AbstractDocumentProperties\<T> class

**BuiltInProperties** class inherit from the **AbstractDocumentProperties\<T>** class,
which is an abstract class that provides common functionality for working with two types of document properties:
**BuiltInProperties** and **CustomProperties**. 
The first type represents a collection of **BuiltInProperty** items, 
while the second type represents a collection of **CustomProperty** items.

Both types of properties derive from **DocumentProperty** class, 
which declares common properties for both types of properties, such as **Name**, **Value**, and **Type**.

The **Name** property is declared in **NamedModelElement** class, which is a base class for all named elements in the document model.
It provides a set accessor for the name of the property, which notifies the document model about the change of the property name.

The **Value** property is declared in the **DocumentProperty** class, and is of type string.
The **Type** property is also declared in the **DocumentProperty** class, and is of type **DocPropertyType** enum, 
which represents the allowed data type of the property value.
Five types of property values are supported: **String**, **Number** (integer 32-bit), **Boolean**, **Date** (DateTime), and **Float** (single or double precision).

DocumentProperty values must be converted to the appropriate type when working with the property value,
which is done in the **DocPropertyTypeExtensions** class, in its **ConvertObjectToString** and **ConvertStringToObject** methods.
Float type conversion is implemented using invariant culture
and Date type conversion is implemented using "o" format, which allows for round-trip date and time conversion.
Those properties which are of unsupported types, are converted using JSON serialization and Base64 encoding, which allows for storing complex objects in a string format.
