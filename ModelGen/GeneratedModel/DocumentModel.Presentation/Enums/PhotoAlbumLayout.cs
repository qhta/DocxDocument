namespace DocumentModel.Presentation;

/// <summary>
/// Photo Album Layout Definition
/// </summary>
public enum PhotoAlbumLayout
{
  /// <summary>
  /// Fit Photos to Slide.
  /// </summary>
  [XmlEnum("fitToSlide")]
  FitToSlide,
  
  /// <summary>
  /// 1 Photo per Slide.
  /// </summary>
  [XmlEnum("1pic")]
  OnePic,
  
  /// <summary>
  /// 2 Photos per Slide.
  /// </summary>
  [XmlEnum("2pic")]
  TwoPic,
  
  /// <summary>
  /// 4 Photos per Slide.
  /// </summary>
  [XmlEnum("4pic")]
  FourPic,
  
  /// <summary>
  /// 1 Photo per Slide with Titles.
  /// </summary>
  [XmlEnum("1picTitle")]
  OnePicWithTitle,
  
  /// <summary>
  /// 2 Photos per Slide with Titles.
  /// </summary>
  [XmlEnum("2picTitle")]
  TwoPicWithTitle,
  
  /// <summary>
  /// 4 Photos per Slide with Titles.
  /// </summary>
  [XmlEnum("4picTitle")]
  FourPicWithTitle,
  
}
