namespace DocumentModel.Presentation;

/// <summary>
/// Presentation.
/// </summary>
public interface IPresentation // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// serverZoom
  /// </summary>
  public System.Int32? ServerZoom { get ; set; }
  
  /// <summary>
  /// firstSlideNum
  /// </summary>
  public System.Int32? FirstSlideNum { get ; set; }
  
  /// <summary>
  /// showSpecialPlsOnTitleSld
  /// </summary>
  public System.Boolean? ShowSpecialPlaceholderOnTitleSlide { get ; set; }
  
  /// <summary>
  /// rtl
  /// </summary>
  public System.Boolean? RightToLeft { get ; set; }
  
  /// <summary>
  /// removePersonalInfoOnSave
  /// </summary>
  public System.Boolean? RemovePersonalInfoOnSave { get ; set; }
  
  /// <summary>
  /// compatMode
  /// </summary>
  public System.Boolean? CompatibilityMode { get ; set; }
  
  /// <summary>
  /// strictFirstAndLastChars
  /// </summary>
  public System.Boolean? StrictFirstAndLastChars { get ; set; }
  
  /// <summary>
  /// embedTrueTypeFonts
  /// </summary>
  public System.Boolean? EmbedTrueTypeFonts { get ; set; }
  
  /// <summary>
  /// saveSubsetFonts
  /// </summary>
  public System.Boolean? SaveSubsetFonts { get ; set; }
  
  /// <summary>
  /// autoCompressPictures
  /// </summary>
  public System.Boolean? AutoCompressPictures { get ; set; }
  
  /// <summary>
  /// bookmarkIdSeed
  /// </summary>
  public System.UInt32? BookmarkIdSeed { get ; set; }
  
  /// <summary>
  /// conformance
  /// </summary>
  public DocumentModel.Presentation.ConformanceClassKind? Conformance { get ; set; }
  
  /// <summary>
  /// SlideMasterIdList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SlideMasterIdList { get ; set; }
  
  /// <summary>
  /// NotesMasterIdList.
  /// </summary>
  public DocumentModel.Presentation.INotesMasterIdList? NotesMasterIdList { get ; set; }
  
  /// <summary>
  /// HandoutMasterIdList.
  /// </summary>
  public DocumentModel.Presentation.IHandoutMasterIdList? HandoutMasterIdList { get ; set; }
  
  /// <summary>
  /// SlideIdList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SlideIdList { get ; set; }
  
  /// <summary>
  /// SlideSize.
  /// </summary>
  public DocumentModel.Presentation.ISlideSize? SlideSize { get ; set; }
  
  /// <summary>
  /// NotesSize.
  /// </summary>
  public DocumentModel.Presentation.IPositiveSize2DType? NotesSize { get ; set; }
  
  /// <summary>
  /// EmbeddedFontList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EmbeddedFontList { get ; set; }
  
  /// <summary>
  /// CustomShowList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? CustomShowList { get ; set; }
  
  /// <summary>
  /// PhotoAlbum.
  /// </summary>
  public DocumentModel.Presentation.IPhotoAlbum? PhotoAlbum { get ; set; }
  
  /// <summary>
  /// CustomerDataList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? CustomerDataList { get ; set; }
  
  /// <summary>
  /// Kinsoku.
  /// </summary>
  public DocumentModel.Presentation.IKinsoku? Kinsoku { get ; set; }
  
  /// <summary>
  /// DefaultTextStyle.
  /// </summary>
  public DocumentModel.Presentation.ITextListStyleType? DefaultTextStyle { get ; set; }
  
  /// <summary>
  /// ModificationVerifier.
  /// </summary>
  public DocumentModel.Presentation.IModificationVerifier? ModificationVerifier { get ; set; }
  
  /// <summary>
  /// PresentationExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PresentationExtensionList { get ; set; }
  
}
