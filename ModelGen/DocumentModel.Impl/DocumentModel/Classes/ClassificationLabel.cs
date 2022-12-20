namespace DocumentModel;

/// <summary>
/// Defines the ClassificationLabel Class.
/// </summary>
public partial class ClassificationLabelImpl: ModelElementImpl, ClassificationLabel
{
  public DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ClassificationLabelImpl(): base() {}
  
  public ClassificationLabelImpl(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2021 and later.
  /// </summary>
  public Boolean? Enabled
  {
    get => (System.Boolean?)OpenXmlElement?.Enabled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Enabled = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// setDate, this property is only available in Office 2021 and later.
  /// </summary>
  public String? SetDate
  {
    get => (System.String?)OpenXmlElement?.SetDate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SetDate = (System.String?)value;
    }
  }
  
  /// <summary>
  /// method, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Method
  {
    get => (System.String?)OpenXmlElement?.Method?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Method = (System.String?)value;
    }
  }
  
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// siteId, this property is only available in Office 2021 and later.
  /// </summary>
  public String? SiteId
  {
    get => (System.String?)OpenXmlElement?.SiteId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SiteId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// actionId, this property is only available in Office 2021 and later.
  /// </summary>
  public String? ActionId
  {
    get => (System.String?)OpenXmlElement?.ActionId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ActionId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// contentBits, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? ContentBits
  {
    get => (System.UInt32?)OpenXmlElement?.ContentBits?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ContentBits = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// removed, this property is only available in Office 2021 and later.
  /// </summary>
  public Boolean? Removed
  {
    get => (System.Boolean?)OpenXmlElement?.Removed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Removed = (System.Boolean?)value;
    }
  }
  
}
