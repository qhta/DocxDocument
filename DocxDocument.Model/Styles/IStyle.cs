namespace DocxDocument.Model;

public interface IStyle
{

  /// <summary> 
  /// Returns standard identifier based on local name.
  ///</summary> 
  String ID { get; }

  /// <summary> 
  /// Returns the style type.
  ///</summary> 
  StyleType Type { get; set; }

  /// <summary> 
  /// Returns the description of the specified style. A typical example of a description for a style might be Normal + Font: Arial, 12 pt, Bold, Italic, Space Before 12 pt After 3 pt, KeepWithNext, Level 2.
  ///</summary> 
  String Description { get; set; }

  /// <summary> 
  /// True if the specified style is a built-in style that has been modified or applied in the document or a new style that has been created in the document. The InUse property doesn't necessarily indicate whether the style is currently applied to any text in the document. For instance, if text that's been formatted with a style is deleted, the InUse property of the style remains True. For built-in styles that have never been used in the document, this property returns False.
  ///</summary> 
  Boolean InUse { get; set; }
  /// <summary> 
  /// Returns the name of a built-in style in English.
  ///</summary> 
  String OrigName { get; set; }

  /// <summary> 
  /// Returns the name of a style in the language of the user. Setting this property renames a user-defined style or adds an alias to a built-in style.
  ///</summary> 
  String Name { get; set; }

  /// <summary> 
  /// Returns or sets an existing style on which you can base the formatting of another style. To set the BaseStyle property, specify either the local name of the base style, an integer or a wdBuiltinStyle constant, or an object that represents the base style. For a list of the wdBuiltinStyle constants, see the Style property for the object that you want to set.
  ///</summary> 
  Variant? BaseStyle { get; set; }

  /// <summary> 
  /// Returns a Boolean that represents whether a style is a linked style that can be used for both paragraph and character formatting.
  ///</summary> 
  Boolean Linked { get; set; }

  /// <summary> 
  /// Sets or returns a Variant that represents a link between a paragraph and a character style.
  ///</summary>
  Variant? LinkStyle { get; set; }

  /// <summary> 
  /// True if the style is automatically redefined based on the selection. If the AutomaticallyUpdate property is set to False, Microsoft Word prompts for confirmation before redefining the style based on the selection. A style can be redefined when it is applied to a selection that has the same style but different manual formatting. The AutomaticallyUpdate property applies to paragraph styles only.
  ///</summary> 
  bool AutomaticallyUpdate { get; set; }

  /// <summary> 
  /// Returns or sets the style to be applied automatically to a new paragraph that is inserted after a paragraph formatted with the specified style. You can set the NextParagraphStyle property by using the local name of the style, an integer or a WdBuiltinStyle constant, or an object that represents the next style. For a list of the WdBuiltinStyle constants, see the Style property for the object that you want to set.
  ///</summary> 
  Variant? NextParagraphStyle { get; set; }

  /// <summary> 
  /// True if the spelling and grammar checker ignores text formatted with this style.
  ///</summary> 
  bool? NoProofing { get; set; }

  /// <summary> 
  /// True if the specified style is not shown in application UI.
  ///</summary> 
  bool Hidden { get; set; }

  /// <summary> 
  /// True if the specified style is hidden in part of application UI.
  ///</summary> 
  bool SemiHidden { get; set; }

  /// <summary> 
  /// True if the specified style is made visible as a recommended style in the Styles and in the Styles task pane in Word after it is used in the document.
  ///</summary> 
  bool UnhideWhenUsed { get; set; }

  /// <summary> 
  /// Returns or sets a Long that represents the priority for sorting styles in the Styles task pane.
  ///</summary> 
  int? UiPriority { get; set; }

  /// <summary> 
  /// True if a style cannot be changed or edited.
  ///</summary> 
  bool Locked { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether the style corresponds to an available quick style.
  ///</summary> 
  bool PrimaryStyle { get; set; }

  /// <summary> 
  /// Returns the list level for the specified style.
  ///</summary> 
  int? ListLevelNumber { get; set; }

  ///// <summary> 
  ///// Returns a Borders collection that represents all the borders for the specified paragraph.
  /////</summary> 
  //Borders Borders { get; set; }

  ///// <summary> 
  ///// Returns or sets a Font object that represents the character formatting of the specified object.
  /////</summary> 
  //Font Font { get; set; }

  ///// <summary> 
  ///// Returns a Frame object that represents the frame formatting for the specified style.
  /////</summary> 
  //Frame Frame { get; set; }

  ///// <summary> 
  ///// Returns or sets a WdLanguageID constant that represents the language for the specified range
  /////</summary> 
  //WdLanguageID LanguageID { get; set; }

  ///// <summary> 
  ///// Returns or sets an East Asian language for the specified object. Read/write WdLanguageID.
  /////</summary> 
  //WdLanguageID LanguageIDFarEast { get; set; }

  ///// <summary> 
  ///// Returns a ListTemplate object that represents the list formatting for the specified Style object.
  /////</summary> 
  //Object ListTemplate { get; set; }

  ///// <summary> 
  ///// True for Microsoft Word to remove spacing between paragraphs that are formatted using the same style.
  /////</summary> 
  //Boolean NoSpaceBetweenParagraphsOfSameStyle { get; set; }

  ///// <summary> 
  ///// Returns or sets a ParagraphFormat object that represents the formatting of the specified paragraph or paragraphs.
  /////</summary> 
  //ParagraphFormat ParagraphFormat { get; set; }

  ///// <summary> 
  ///// Returns a Shading object that refers to the shading formatting for the specified object.
  /////</summary> 
  //Shading Shading { get; set; }

  ///// <summary> 
  ///// Returns a TableStyle object representing properties that can be applied to a table using a table style.
  /////</summary> 
  //TableStyle Table { get; set; }


}