namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class Address
{
  public bool ShouldSerializeAddress1() => !String.IsNullOrEmpty(Address1);
  public bool ShouldSerializeCountryRegion() => !String.IsNullOrEmpty(CountryRegion);
  public bool ShouldSerializeAdminDistrict1() => !String.IsNullOrEmpty(AdminDistrict1);
  public bool ShouldSerializeAdminDistrict2() => !String.IsNullOrEmpty(AdminDistrict2);
  public bool ShouldSerializePostalCode() => !String.IsNullOrEmpty(PostalCode);
  public bool ShouldSerializeLocality() => !String.IsNullOrEmpty(Locality);
  public bool ShouldSerializeIsoCountryCode() => !String.IsNullOrEmpty(IsoCountryCode);
}
