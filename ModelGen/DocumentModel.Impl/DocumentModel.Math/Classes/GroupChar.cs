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
  
  public GroupCharImpl(): base() {}
  
  public GroupCharImpl(DocumentFormat.OpenXml.Math.GroupChar openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Group-Character Properties.
  /// </summary>
  public DocumentModel.Math.GroupCharProperties? GroupCharProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
