namespace DocumentModel.Presentation;

/// <summary>
/// Presentation.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.INotesSize))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IDefaultTextStyle))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICustomerDataList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICustomShowList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IEmbeddedFontList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IHandoutMasterIdList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IKinsoku))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IModificationVerifier))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INotesMasterIdList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPhotoAlbum))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPresentationExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideIdList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideMasterIdList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideSize))]
public class Presentation: IPresentation
{
  /// <summary>
  /// serverZoom
  /// </summary>
  public int? ServerZoom
  {
    get;
    set;
  }
  
  /// <summary>
  /// firstSlideNum
  /// </summary>
  public int? FirstSlideNum
  {
    get;
    set;
  }
  
  /// <summary>
  /// showSpecialPlsOnTitleSld
  /// </summary>
  public bool? ShowSpecialPlaceholderOnTitleSlide
  {
    get;
    set;
  }
  
  /// <summary>
  /// rtl
  /// </summary>
  public bool? RightToLeft
  {
    get;
    set;
  }
  
  /// <summary>
  /// removePersonalInfoOnSave
  /// </summary>
  public bool? RemovePersonalInfoOnSave
  {
    get;
    set;
  }
  
  /// <summary>
  /// compatMode
  /// </summary>
  public bool? CompatibilityMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// strictFirstAndLastChars
  /// </summary>
  public bool? StrictFirstAndLastChars
  {
    get;
    set;
  }
  
  /// <summary>
  /// embedTrueTypeFonts
  /// </summary>
  public bool? EmbedTrueTypeFonts
  {
    get;
    set;
  }
  
  /// <summary>
  /// saveSubsetFonts
  /// </summary>
  public bool? SaveSubsetFonts
  {
    get;
    set;
  }
  
  /// <summary>
  /// autoCompressPictures
  /// </summary>
  public bool? AutoCompressPictures
  {
    get;
    set;
  }
  
  /// <summary>
  /// bookmarkIdSeed
  /// </summary>
  public uint? BookmarkIdSeed
  {
    get;
    set;
  }
  
  /// <summary>
  /// conformance
  /// </summary>
  public ConformanceClassValues? Conformance
  {
    get;
    set;
  }
  
  /// <summary>
  /// SlideMasterIdList.
  /// </summary>
  public ISlideMasterIdList? SlideMasterIdList
  {
    get;
    set;
  }
  
  /// <summary>
  /// NotesMasterIdList.
  /// </summary>
  public INotesMasterIdList? NotesMasterIdList
  {
    get;
    set;
  }
  
  /// <summary>
  /// HandoutMasterIdList.
  /// </summary>
  public IHandoutMasterIdList? HandoutMasterIdList
  {
    get;
    set;
  }
  
  /// <summary>
  /// SlideIdList.
  /// </summary>
  public ISlideIdList? SlideIdList
  {
    get;
    set;
  }
  
  /// <summary>
  /// SlideSize.
  /// </summary>
  public ISlideSize? SlideSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// NotesSize.
  /// </summary>
  public INotesSize? NotesSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// EmbeddedFontList.
  /// </summary>
  public IEmbeddedFontList? EmbeddedFontList
  {
    get;
    set;
  }
  
  /// <summary>
  /// CustomShowList.
  /// </summary>
  public ICustomShowList? CustomShowList
  {
    get;
    set;
  }
  
  /// <summary>
  /// PhotoAlbum.
  /// </summary>
  public IPhotoAlbum? PhotoAlbum
  {
    get;
    set;
  }
  
  /// <summary>
  /// CustomerDataList.
  /// </summary>
  public ICustomerDataList? CustomerDataList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Kinsoku.
  /// </summary>
  public DocumentModel.Presentation.IKinsoku? Kinsoku
  {
    get;
    set;
  }
  
  /// <summary>
  /// DefaultTextStyle.
  /// </summary>
  public IDefaultTextStyle? DefaultTextStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// ModificationVerifier.
  /// </summary>
  public IModificationVerifier? ModificationVerifier
  {
    get;
    set;
  }
  
  /// <summary>
  /// PresentationExtensionList.
  /// </summary>
  public IPresentationExtensionList? PresentationExtensionList
  {
    get;
    set;
  }
  
}
