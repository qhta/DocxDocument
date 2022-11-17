namespace DocumentModel.Wordprocessing;

public enum RubyAlign
{

  [XmlEnum("center")]
  Center,

  [XmlEnum("distributeLetter")]
  DistributeLetter,

  [XmlEnum("distributeSpace")]
  DistributeSpace,

  [XmlEnum("left")]
  Left,

  [XmlEnum("right")]
  Right,

  [XmlEnum("rightVertical")]
  RightVertical,
}
