namespace DocxDocument.Model;

public class Style: IStyle
{

  /// <summary> 
  /// Returns the style type.
  ///</summary>
  [XmlAttribute]
  public StyleType Type { get; set; }

  /// <summary> 
  /// Returns the name of a built-in style in English.
  ///</summary> 
  [XmlAttribute]
  public String OrigName { get; set; } = null!;

  /// <summary> 
  /// Returns the name of a style in the language of the user. Setting this property renames a user-defined style or adds an alias to a built-in style.
  ///</summary> 
  [XmlAttribute]
  public String Name { get; set; } = null!;

  #region style options
  /// <summary> 
  /// True if the specified style is default for its style type.
  ///</summary> 
  [XmlAttribute]
  [DefaultValue(false)]
  public bool Default { get; set; }

  /// <summary> 
  /// True if the specified style is not shown in application UI.
  ///</summary> 
  [XmlAttribute]
  [DefaultValue(false)]
  public bool Hidden { get; set; }

  /// <summary> 
  /// True if the specified style is hidden in part of application UI.
  ///</summary> 
  [XmlAttribute]
  [DefaultValue(false)]
  public bool SemiHidden { get; set; }

  /// <summary> 
  /// True if the specified style is made visible as a recommended style in the Styles and in the Styles task pane in Word after it is used in the document.
  ///</summary> 
  [XmlAttribute]
  [DefaultValue(false)]
  public bool UnhideWhenUsed { get; set; }


  /// <summary> 
  /// Returns or sets a Long that represents the priority for sorting styles in the Styles task pane.
  ///</summary> 
  [XmlAttribute]
  [DefaultValue(0)]
  public int? UiPriority { get; set; }

  /// <summary> 
  /// True if a style cannot be changed or edited.
  ///</summary> 
  [XmlAttribute]
  [DefaultValue(false)]
  public bool Locked { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether the style corresponds to an available quick style.
  ///</summary> 
  [XmlAttribute]
  [DefaultValue(false)]
  public bool PrimaryStyle { get; set; }
  #endregion

  /// <summary> 
  /// Returns or sets an existing style on which you can base the formatting of another style. To set the BaseStyle property, specify either the local name of the base style, an integer or a wdBuiltinStyle constant, or an object that represents the base style. For a list of the wdBuiltinStyle constants, see the Style property for the object that you want to set.
  ///</summary> 
  [XmlAttribute]
  public Variant? BaseStyle { get; set; }

  /// <summary> 
  /// Returns a Boolean that represents whether a style is a linked style that can be used for both paragraph and character formatting.
  ///</summary> 
  [XmlAttribute]
  [DefaultValue(false)]
  public Boolean Linked { get; set; }

  /// <summary> 
  /// Sets or returns a Variant that represents a link between a paragraph and a character style.
  ///</summary> 
  [XmlAttribute]
  public Variant? LinkStyle { get; set; }

  /// <summary> 
  /// True if the style is automatically redefined based on the selection. If the AutomaticallyUpdate property is set to False, Microsoft Word prompts for confirmation before redefining the style based on the selection. A style can be redefined when it is applied to a selection that has the same style but different manual formatting. The AutomaticallyUpdate property applies to paragraph styles only.
  ///</summary> 
  [XmlAttribute]
  [DefaultValue(false)]
  public Boolean AutomaticallyUpdate { get; set; }

  /// <summary> 
  /// Returns or sets the style to be applied automatically to a new paragraph that is inserted after a paragraph formatted with the specified style. You can set the NextParagraphStyle property by using the local name of the style, an integer or a WdBuiltinStyle constant, or an object that represents the next style. For a list of the WdBuiltinStyle constants, see the Style property for the object that you want to set.
  ///</summary> 
  [XmlAttribute]
  public Variant? NextParagraphStyle { get; set; }

  /// <summary> 
  /// True if the spelling and grammar checker ignores text formatted with this style.
  ///</summary> 
  [XmlAttribute]
  [DefaultValue(false)]
  public bool? NoProofing { get; set; }

  /// <summary> 
  /// Returns the list level for the specified style.
  ///</summary> 
  [XmlAttribute]
  public int? ListLevelNumber { get; set; }

  ///// <summary> 
  ///// Returns a Borders collection that represents all the borders for the specified paragraph.
  /////</summary> 
  //Borders Borders { get; set; }

  /// <summary> 
  /// Returns or sets an object that represents the character formatting of the specified object.
  ///</summary> 
  public RunProperties? RunProperties { get; set; }

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

  /// <summary> 
  /// Returns the description of the specified style. A typical example of a description for a style might be Normal + Font: Arial, 12 pt, Bold, Italic, Space Before 12 pt After 3 pt, KeepWithNext, Level 2.
  ///</summary> 
  public String? Description { get; set; } = null!;

  /// <summary> 
  /// True if the specified style is a built-in style that has been modified or applied in the document or a new style that has been created in the document. The InUse property doesn't necessarily indicate whether the style is currently applied to any text in the document. For instance, if text that's been formatted with a style is deleted, the InUse property of the style remains True. For built-in styles that have never been used in the document, this property returns False.
  ///</summary>
  [XmlAttribute]
  [DefaultValue(false)]
  public Boolean InUse { get; set; }

  /// <summary> 
  /// Returns standard identifier based on local name.
  ///</summary> 
  public string? ID => NameToID(Name);

  /// <summary>
  /// Converts name to identifier by removing all characters exept latin letters and digits.
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  public static string? NameToID(string? name)
  {
    if (name == null)
      return null;
    var chars = new List<Char>();
    foreach (var ch in name)
      if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch >= '0' && ch <= '9')
        chars.Add(ch);
    return new String(chars.ToArray());
  }
}