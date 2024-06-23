using System.Diagnostics;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace ModelDoc;

public class ModelsDbContext : DbContext
{
  public DbSet<Namespace> Namespaces { get; set; }

  public DbSet<SchemaFile> SchemaFiles { get; set; }

  public DbSet<SchemaNamespace> SchemaNamespaces { get; set; }

  public DbSet<SchemaUsedNamespace> SchemaUsedNamespaces { get; set; }

  //public DbSet<SchemaType> SchemaTypes { get; set; }

  public DbSet<SchemaSimpleType> SchemaSimpleTypes { get; set; }

  public DbSet<SchemaComplexType> SchemaComplexTypes { get; set; }

  public DbSet<SchemaEnumValue> SchemaEnumValues { get; set; }

  public DbSet<SchemaPattern> SchemaPatterns { get; set; }

  public DbSet<SchemaUnionMember> SchemaUnionMembers { get; set; }

  public DbSet<SchemaListItem> SchemaListItems { get; set; }

  public DbSet<SchemaAttribute> SchemaAttributes { get; set; }

  public DbSet<SchemaAttributeGroup> SchemaAttributeGroups { get; set; }

  public DbSet<SchemaAttributeGroupRef> SchemaAttributeGroupRefs { get; set; }

  public DbSet<SchemaParticle> SchemaParticles { get; set; }

  public DbSet<SchemaGroup> SchemaGroups { get; set; }

  public SchemaElements SchemaElements
  {
    get
    {
      if (_SchemaElements == null)
      {
        _SchemaElements = new SchemaElements(SchemaParticles);
      }

      return _SchemaElements;
    }
  }
  private SchemaElements? _SchemaElements;

  public string DbPath { get; } = @"d:\VS\Docs\DocumentModel\Models.accdb";

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VS\Docs\DocumentModel\Models.accdb;");
    //optionsBuilder.LogTo(message => Debug.WriteLine(message));
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    //modelBuilder.Entity<SchemaType>()
    //  .HasDiscriminator<bool>("IsComplex")
    //  .HasValue<SchemaSimpleType>(false)
    //  .HasValue<SchemaComplexType>(true);

    //modelBuilder.Entity<SchemaType>()
    //  .Property("IsComplex").HasColumnType("bit");

    modelBuilder.Entity<SchemaParticle>()
      .HasDiscriminator<ParticleType>("ParticleType")
      .HasValue<SchemaAny>(ParticleType.Any)
      .HasValue<SchemaElement>(ParticleType.Element)
      .HasValue<SchemaGroupRef>(ParticleType.GroupRef)
      .HasValue<SchemaAll>(ParticleType.All)
      .HasValue<SchemaChoice>(ParticleType.Choice)
      .HasValue<SchemaSequence>(ParticleType.Sequence);

    modelBuilder.Entity<SchemaParticle>()
      .Property("ParticleType").HasColumnType("byte");

    modelBuilder.Entity<SchemaElement>()
      .Property(e => e.Name)
      .HasColumnName("Name");

    modelBuilder.Entity<SchemaGroupRef>()
      .Property(e => e.RefName)
      .HasColumnName("Name");

    modelBuilder.Entity<SchemaElement>()
      .Property(e => e.RefNamespaceId)
      .HasColumnName("RefNamespaceId");

    modelBuilder.Entity<SchemaGroupRef>()
      .Property(e => e.RefNamespaceId)
      .HasColumnName("RefNamespaceId");

    modelBuilder.Entity<SchemaParticle>()
      .HasOne(p => p.ParentComplexType)
      .WithMany() // Assuming SchemaComplexType has a collection of SchemaParticles
      .HasForeignKey(p => p.ComplexTypeId)
      .OnDelete(DeleteBehavior.Restrict); // Customize the delete behavior as needed

    modelBuilder.Entity<SchemaParticle>()
        .HasOne(p => p.ParentGroup)
        .WithMany() // Assuming SchemaGroup has a collection of SchemaParticles
        .HasForeignKey(p => p.GroupId)
        .OnDelete(DeleteBehavior.Restrict); // Customize the delete behavior as needed

    //modelBuilder.Entity<SchemaGroup>()
    //  .Navigation(e => e.ParentNamespace)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);

    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentNamespace)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);

    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentComplexType)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);

    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentGroup)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);


    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentParticle)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);


    //modelBuilder.Entity<SchemaGroupBase>()
    //  .Navigation(e => e.Items)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);

    //modelBuilder.Entity<SchemaParticle>()
    //  .Navigation(e => e.ParentParticle)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);
  }

}
