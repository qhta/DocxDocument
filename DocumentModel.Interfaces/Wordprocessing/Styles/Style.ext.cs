namespace DocumentModel.Wordprocessing;

public partial interface Style : IModelElement, AliasedObject
{
  /// <summary>
  ///   Primary Style Name.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Specifies the set of alternative names for the parent style definition. 
  ///   These names can be used in an application's user interface as desired. 
  ///   Each name shall be separated by one or more consecutive comma characters (Unicode character value 002C). 
  ///   All commas present shall be interpreted as separator character and never as part of an alternate style name.
  /// </summary>
  public new StringList? Aliases { get; set; }

  IEnumerable<string>? AliasedObject.Aliases => Aliases;

  /// <summary>
  /// Determines whether any properties are defined.
  /// </summary>
  public bool IsDefined { get; }

  /// <summary>
  /// Determines whether suitable properties are defined for specific style types.
  /// </summary>
  public bool IsVl { get; }
}