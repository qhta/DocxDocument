namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public class Shape1Impl: ModelElementImpl, Shape1
{
  public DocumentFormat.OpenXml.Office.Drawing.Shape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.Shape?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// modelId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ModelId
  {
    get => (String?)OpenXmlElement?.ModelId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ModelId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  public ShapeNonVisualProperties? ShapeNonVisualProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties6? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public ShapeStyle1? ShapeStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TextBody.
  /// </summary>
  public TextBody3? TextBody
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public Transform2D3? Transform2D
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList1? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
