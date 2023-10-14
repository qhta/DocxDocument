namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a structured document tag around one or more block-level structures (paragraphs, tables, etc.). The two child elements of this element shall be used to specify the properties and content of the current structured document tag via the sdtPr and sdtContent elements, respectively.
/// </summary>
public partial class SdtRunRuby
{
  
  /// <summary>
  ///   SdtContentRunRuby.
  /// </summary>
  public DocumentModel.Wordprocessing.SdtContentRunRuby? SdtContentRunRuby { get; set; }
  
  public DocumentModel.Wordprocessing.SdtProperties? SdtProperties { get; set; }
  
  public DocumentModel.Wordprocessing.SdtEndCharProperties? SdtEndCharProperties { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
