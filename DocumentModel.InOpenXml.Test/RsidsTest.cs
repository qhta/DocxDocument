using Qhta.OpenXmlTools;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.Rsids.
/// </summary>
public class RsidsTest: _AbstractModelTestClass<Rsids>
{

  /// <summary>
  /// Creates a sample Rsids object with various property types.
  /// </summary>
  /// <returns>A populated Rsids object.</returns>
  protected override Rsids CreateSampleData()
  {
    var props = new Rsids();
    for (int i=1; i<=10; i++)
    {
      props.Add(i);
    }
    return props;
  }

  /// <summary>
  /// Updates the data within the specified document using the provided data information.
  /// </summary>
  /// <param name="document">The document to update with new data.</param>
  /// <param name="data">The Rsids information to use when updating the document.</param>
  /// <returns>A new or updated Rsids object representing the result of the update operation.</returns>
  /// <exception cref="NotImplementedException">Always thrown, as this method is not implemented.</exception>
  protected override Rsids UpdateDataInDocument(Document document, Rsids data)
  {
    data.Add(data.Count+1);
    return document.Rsids;
  }

  /// <summary>
  /// Get the Open XML representation of the document's Rsids data.
  /// </summary>
  /// <param name="document">The document from which to retrieve the OpenXml representation.</param>
  /// <returns>The OpenXml representation of the document's Rsids data.</returns>
  /// <exception cref="NotImplementedException">Always thrown, as this method is not implemented.</exception>
  protected override string GetOpenXmlFromDocument(Document document)
  {
    return document.WordprocessingDocument!.MainDocumentPart!.DocumentSettingsPart!.Settings!.OuterXml;
  }
}