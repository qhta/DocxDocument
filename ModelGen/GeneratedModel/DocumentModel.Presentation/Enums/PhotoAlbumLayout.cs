namespace DocumentModel.Presentation;

public enum PhotoAlbumLayout
{

  [XmlEnum("fitToSlide")]
  FitToSlide,

  [XmlEnum("1pic")]
  OnePic,

  [XmlEnum("2pic")]
  TwoPic,

  [XmlEnum("4pic")]
  FourPic,

  [XmlEnum("1picTitle")]
  OnePicWithTitle,

  [XmlEnum("2picTitle")]
  TwoPicWithTitle,

  [XmlEnum("4picTitle")]
  FourPicWithTitle,
}
