namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies which forms of annotations shall be visible for a WordprocessingML document when it is displayed. 
/// This setting shall not affect whether annotations are added or persisted, 
/// it shall only affect the display of the annotations which exist in the document's contents (persisted or in memory).
/// </summary>
[DataContract]
public partial class RevisionView : IOpenXmlElementMappedObject
{
  public RevisionView()
  {
    _Element = new DXW.RevisionView();
  }

  public RevisionView(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.RevisionView)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public RevisionView(DXW.RevisionView openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.RevisionView _Element { get; private set; }

  /// <summary>
  /// Display Visual Indicator Of Markup Area
  /// </summary>
  [DataMember]
  public Boolean? Markup
  {
    get => _Element.Markup?.Value;
    set => _Element.Markup = value;
  }

  /// <summary>
  /// Display Comments
  /// </summary>
  [DataMember]
  public Boolean? Comments
  {
    get => _Element.Comments?.Value;
    set => _Element.Comments = value;
  }

  /// <summary>
  /// Display Content Revisions
  /// </summary>
  [DataMember]
  public Boolean? DisplayRevision
  {
    get => _Element.DisplayRevision?.Value;
    set => _Element.DisplayRevision = value;
  }

  /// <summary>
  /// Display Formatting Revisions
  /// </summary>
  [DataMember]
  public Boolean? Formatting
  {
    get => _Element.Formatting?.Value;
    set => _Element.Formatting = value;
  }

  /// <summary>
  /// Display Ink Annotations
  /// </summary>
  [DataMember]
  public Boolean? InkAnnotations
  {
    get => _Element.InkAnnotations?.Value;
    set => _Element.InkAnnotations = value;
  }


}

