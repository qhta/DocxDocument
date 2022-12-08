namespace DocumentModel.Math;

/// <summary>
/// Group-Character Function.
/// </summary>
public class GroupCharImpl: ModelElementImpl, GroupChar
{
  public DocumentFormat.OpenXml.Math.GroupChar? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.GroupChar?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Group-Character Properties.
  /// </summary>
  public GroupCharProperties? GroupCharProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base
  {
    get;
    set;
  }
  
}
