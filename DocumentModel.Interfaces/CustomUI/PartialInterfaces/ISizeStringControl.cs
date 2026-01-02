namespace DocumentModel;

/// <summary>
/// Interface for controls that support the SizeString attribute.
/// </summary>
public interface ISizeStringControl
{ /// <summary>
  ///   Specifies a string whose size is used to determine the width of the text input area of this control (e.g., "WWWW").
  ///
  ///  If this attribute is omitted, the application SHOULD determine the width of the text input area of the control automatically.
  /// </summary>
  public string? SizeString
  {
    get; set;
  }