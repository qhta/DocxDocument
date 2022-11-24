namespace DocumentModel.Presentation;

/// <summary>
/// Presentation.
/// </summary>
public interface IPresentation // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// serverZoom
  /// </summary>
  public Int32? ServerZoom { get ; set; }
  
  /// <summary>
  /// firstSlideNum
  /// </summary>
  public Int32? FirstSlideNum { get ; set; }
  
  /// <summary>
  /// showSpecialPlsOnTitleSld
  /// </summary>
  public Boolean? ShowSpecialPlaceholderOnTitleSlide { get ; set; }
  
  /// <summary>
  /// rtl
  /// </summary>
  public Boolean? RightToLeft { get ; set; }
  
  /// <summary>
  /// removePersonalInfoOnSave
  /// </summary>
  public Boolean? RemovePersonalInfoOnSave { get ; set; }
  
  /// <summary>
  /// compatMode
  /// </summary>
  public Boolean? CompatibilityMode { get ; set; }
  
  /// <summary>
  /// strictFirstAndLastChars
  /// </summary>
  public Boolean? StrictFirstAndLastChars { get ; set; }
  
  /// <summary>
  /// embedTrueTypeFonts
  /// </summary>
  public Boolean? EmbedTrueTypeFonts { get ; set; }
  
  /// <summary>
  /// saveSubsetFonts
  /// </summary>
  public Boolean? SaveSubsetFonts { get ; set; }
  
  /// <summary>
  /// autoCompressPictures
  /// </summary>
  public Boolean? AutoCompressPictures { get ; set; }
  
  /// <summary>
  /// bookmarkIdSeed
  /// </summary>
  public UInt32? BookmarkIdSeed { get ; set; }
  
  /// <summary>
  /// conformance
  /// </summary>
  public ConformanceClassValues? Conformance { get ; set; }
  
  /// <summary>
  /// SlideMasterIdList.
  /// </summary>
  public ISlideMasterIdList? SlideMasterIdList { get ; set; }
  
  /// <summary>
  /// NotesMasterIdList.
  /// </summary>
  public INotesMasterIdList? NotesMasterIdList { get ; set; }
  
  /// <summary>
  /// HandoutMasterIdList.
  /// </summary>
  public IHandoutMasterIdList? HandoutMasterIdList { get ; set; }
  
  /// <summary>
  /// SlideIdList.
  /// </summary>
  public ISlideIdList? SlideIdList { get ; set; }
  
  /// <summary>
  /// SlideSize.
  /// </summary>
  public ISlideSize? SlideSize { get ; set; }
  
  /// <summary>
  /// NotesSize.
  /// </summary>
  public INotesSize? NotesSize { get ; set; }
  
  /// <summary>
  /// EmbeddedFontList.
  /// </summary>
  public IEmbeddedFontList? EmbeddedFontList { get ; set; }
  
  /// <summary>
  /// CustomShowList.
  /// </summary>
  public ICustomShowList? CustomShowList { get ; set; }
  
  /// <summary>
  /// PhotoAlbum.
  /// </summary>
  public IPhotoAlbum? PhotoAlbum { get ; set; }
  
  /// <summary>
  /// CustomerDataList.
  /// </summary>
  public ICustomerDataList? CustomerDataList { get ; set; }
  
  /// <summary>
  /// Kinsoku.
  /// </summary>
  public IKinsoku? Kinsoku { get ; set; }
  
  /// <summary>
  /// DefaultTextStyle.
  /// </summary>
  public IDefaultTextStyle? DefaultTextStyle { get ; set; }
  
  /// <summary>
  /// ModificationVerifier.
  /// </summary>
  public IModificationVerifier? ModificationVerifier { get ; set; }
  
  /// <summary>
  /// PresentationExtensionList.
  /// </summary>
  public IPresentationExtensionList? PresentationExtensionList { get ; set; }
  
  /// <summary>
  /// Gets the PresentationPart associated with this element.
  /// </summary>
  public PresentationPart? PresentationPart { get ; set; }
  
}
