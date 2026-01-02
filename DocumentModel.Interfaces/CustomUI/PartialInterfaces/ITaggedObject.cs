namespace DocumentModel;

/// <summary>
/// Interface for controls that support a tag property.
/// </summary>
/// <remarks>The value of this property is typically passed to callback functions associated with the control. If
/// not set, the property defaults to an empty string.</remarks>
public interface ITaggedObject
{

  /// <summary>
  ///   Specifies an arbitrary string that can be used to hold data or identify the control.
  ///   The contents of this attribute SHOULD be passed to any callback functions specified on this control.
  ///
  ///   If this attribute is omitted, the control's tag value SHOULD default to an empty string.
  /// </summary>
  public string? Tag { get; set; }


}