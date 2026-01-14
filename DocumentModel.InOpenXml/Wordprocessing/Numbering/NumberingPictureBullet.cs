namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a picture numbering symbol definition in a WordprocessingML document.
  /// This interface extends <see cref="CollectionItem"/> and provides properties for the picture bullet ID, base picture bullet definition, and associated drawing, enabling advanced customization of list bullets using images.
  /// </summary>
  public interface NumberingPictureBullet : CollectionItem
  {
    
    /// <summary>
    /// Identifier for the numbering picture bullet, used to reference the picture bullet definition.
    /// </summary>
    public Int32? NumberingPictureBulletId { get; set; }
    
    /// <summary>
    /// Base definition for the picture bullet, specifying the image and formatting used for the bullet symbol.
    /// </summary>
    public DMWV.PictureBulletBase? PictureBulletBase { get; set; }
    
    /// <summary>
    /// Drawing element associated with the picture bullet, containing the image data and rendering information.
    /// </summary>
    public DMDO.Drawing? Drawing { get; set; }
  }