namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies which forms of annotations shall be visible for a WordprocessingML document when it is displayed. 
/// This setting shall not affect whether annotations are added or persisted, 
/// it shall only affect the display of the annotations which exist in the document's contents (persisted or in memory).
/// </summary>
[DataContract]
public partial class RevisionView : ModelElement<DXW.RevisionView>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public RevisionView(): base(){ }

  public RevisionView(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public RevisionView(DXW.RevisionView openXmlElement): base(openXmlElement) { } 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Display Visual Indicator Of Markup Area
  /// </summary>
  [DataMember]
  public bool? Markup
  {
    get => _Element?.Markup?.Value;
    set => _ExistingElement.Markup = value;
  }

  /// <summary>
  /// Display Comments
  /// </summary>
  [DataMember]
  public bool? Comments
  {
    get => _Element?.Comments?.Value;
    set => _ExistingElement.Comments = value;
  }

  /// <summary>
  /// Display Content Revisions
  /// </summary>
  [DataMember]
  public bool? DisplayRevision
  {
    get => _Element?.DisplayRevision?.Value;
    set => _ExistingElement.DisplayRevision = value;
  }

  /// <summary>
  /// Display Formatting Revisions
  /// </summary>
  [DataMember]
  public bool? Formatting
  {
    get => _Element?.Formatting?.Value;
    set => _ExistingElement.Formatting = value;
  }

  /// <summary>
  /// Display Ink Annotations
  /// </summary>
  [DataMember]
  public bool? InkAnnotations
  {
    get => _Element?.InkAnnotations?.Value;
    set => _ExistingElement.InkAnnotations = value;
  }


}

