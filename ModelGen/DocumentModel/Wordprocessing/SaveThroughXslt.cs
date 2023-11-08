namespace DocumentModel.Wordprocessing;


/// <summary>
///   Custom XSL Transform To Use When Saving As XML File.
/// </summary>
public partial class SaveThroughXslt: ModelElement<DXW.SaveThroughXslt>
{
  public SaveThroughXslt(): base(){ }
  
  public SaveThroughXslt(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SaveThroughXslt(DXW.SaveThroughXslt openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   XSL Transformation Location
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Local Identifier for XSL Transform
  /// </summary>
  [DataMember]
  public String? SolutionId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SolutionId);
    }
    set
    {
      _ExistingElement.SolutionId = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
