namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of run properties applied to the glyph used to represent the physical location of the paragraph mark for this paragraph. This paragraph mark, being a physical character in the document, can be formatted, and therefore shall be capable of representing this formatting like any other character in the document.
/// </summary>
public partial class PreviousParagraphMarkRunProperties: ModelElement<DXW.PreviousParagraphMarkRunProperties>
{
  public PreviousParagraphMarkRunProperties(): base(){ }
  
  public PreviousParagraphMarkRunProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreviousParagraphMarkRunProperties(DXW.PreviousParagraphMarkRunProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Inserted Paragraph.
  /// </summary>
  [DataMember]
  public DMW.Inserted? Inserted
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
  }
  
  
  /// <summary>
  ///   Deleted Paragraph.
  /// </summary>
  [DataMember]
  public DMW.Deleted? Deleted
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
  }
  
  
  /// <summary>
  ///   Move Source Paragraph.
  /// </summary>
  [DataMember]
  public DMW.MoveFrom? MoveFrom
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
  }
  
  
  /// <summary>
  ///   Move Destination Paragraph.
  /// </summary>
  [DataMember]
  public DMW.MoveTo? MoveTo
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
  }
  
  [DataMember]
  public DMW10.ConflictInsertion? ConflictInsertion
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.TrackChangeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.TrackChangeType");
  }
  
  [DataMember]
  public DMW10.ConflictDeletion? ConflictDeletion
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.TrackChangeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.TrackChangeType");
  }
  
}
