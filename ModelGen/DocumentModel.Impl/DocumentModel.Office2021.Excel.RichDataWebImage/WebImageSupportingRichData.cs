namespace DocumentModel.Office2021.Excel.RichDataWebImage;

/// <summary>
/// Defines the WebImageSupportingRichData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.RichDataWebImage.IAddressWebImageSupportingRichDataRelationship))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.RichDataWebImage.IMoreImagesAddressWebImageSupportingRichDataRelationship))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.RichDataWebImage.IBlipWebImageSupportingRichDataRelationship))]
public class WebImageSupportingRichData: IWebImageSupportingRichData
{
  /// <summary>
  /// AddressWebImageSupportingRichDataRelationship.
  /// </summary>
  public IAddressWebImageSupportingRichDataRelationship? AddressWebImageSupportingRichDataRelationship
  {
    get;
    set;
  }
  
  /// <summary>
  /// MoreImagesAddressWebImageSupportingRichDataRelationship.
  /// </summary>
  public IMoreImagesAddressWebImageSupportingRichDataRelationship? MoreImagesAddressWebImageSupportingRichDataRelationship
  {
    get;
    set;
  }
  
  /// <summary>
  /// BlipWebImageSupportingRichDataRelationship.
  /// </summary>
  public IBlipWebImageSupportingRichDataRelationship? BlipWebImageSupportingRichDataRelationship
  {
    get;
    set;
  }
  
}
