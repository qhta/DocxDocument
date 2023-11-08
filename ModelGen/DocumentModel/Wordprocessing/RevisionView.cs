namespace DocumentModel.Wordprocessing;


/// <summary>
///   Visibility of Annotation Types.
/// </summary>
public partial class RevisionView: ModelElement<DXW.RevisionView>
{
  public RevisionView(): base(){ }
  
  public RevisionView(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RevisionView(DXW.RevisionView openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Display Visual Indicator Of Markup Area
  /// </summary>
  [DataMember]
  public Boolean? Markup
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Markup);
    }
    set
    {
      _ExistingElement.Markup = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Display Comments
  /// </summary>
  [DataMember]
  public Boolean? Comments
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Comments);
    }
    set
    {
      _ExistingElement.Comments = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Display Content Revisions
  /// </summary>
  [DataMember]
  public Boolean? DisplayRevision
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.DisplayRevision);
    }
    set
    {
      _ExistingElement.DisplayRevision = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Display Formatting Revisions
  /// </summary>
  [DataMember]
  public Boolean? Formatting
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Formatting);
    }
    set
    {
      _ExistingElement.Formatting = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Display Ink Annotations
  /// </summary>
  [DataMember]
  public Boolean? InkAnnotations
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.InkAnnotations);
    }
    set
    {
      _ExistingElement.InkAnnotations = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
