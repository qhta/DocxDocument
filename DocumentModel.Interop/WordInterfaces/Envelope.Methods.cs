namespace DocumentModel.Interop.Word;

public partial interface Envelope
{
  /// <summary>
  /// Executes the insert2000 operation.
  /// </summary>
  /// <param name="ExtractAddress">Specifies the extract address.</param>
  /// <param name="Address">Specifies the address.</param>
  /// <param name="AutoText">Specifies the auto text.</param>
  /// <param name="OmitReturnAddress">Specifies the omit return address.</param>
  /// <param name="ReturnAddress">Specifies the return address.</param>
  /// <param name="ReturnAutoText">Specifies the return auto text.</param>
  /// <param name="PrintBarCode">Specifies the print bar code.</param>
  /// <param name="PrintFIMA">Specifies the print fima.</param>
  /// <param name="Size">Specifies the size.</param>
  /// <param name="Height">Specifies the height.</param>
  /// <param name="Width">Specifies the width.</param>
  /// <param name="FeedSource">Specifies the feed source.</param>
  /// <param name="AddressFromLeft">Specifies the address from left.</param>
  /// <param name="AddressFromTop">Specifies the address from top.</param>
  /// <param name="ReturnAddressFromLeft">Specifies the return address from left.</param>
  /// <param name="ReturnAddressFromTop">Specifies the return address from top.</param>
  /// <param name="DefaultFaceUp">Specifies the default face up.</param>
  /// <param name="DefaultOrientation">Specifies the default orientation.</param>
  public void Insert2000(object ExtractAddress, object Address, object AutoText, object OmitReturnAddress, object ReturnAddress, object ReturnAutoText, object PrintBarCode, object PrintFIMA, object Size, object Height, object Width, object FeedSource, object AddressFromLeft, object AddressFromTop, object ReturnAddressFromLeft, object ReturnAddressFromTop, object DefaultFaceUp, object DefaultOrientation);
}
