namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents an anchor element used to position and manage drawing objects within a WordprocessingML document.
/// </summary>
[DataContract]
[XmlRoot("Anchor", Namespace = "DocumentModel.Wordprocessing.Drawings")]
[OpenXmlType(typeof(DXDW.Anchor))]
public class Anchor: ModelElement<DXDW.Anchor>
{
  
}