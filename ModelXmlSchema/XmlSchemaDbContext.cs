using System.Diagnostics;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using EntityFrameworkCore.Jet;
using System.Xml.Linq;
using System.IO.Compression;

namespace ModelXmlSchema;

public sealed class XmlSchemaDbContext : DbContext
{
  public DbSet<SchemaFile> SchemaFiles { get; set; }

  public DbSet<Namespace> Namespaces { get; set; }

  public DbSet<UsedNamespace> UsedNamespaces { get; set; }

  public DbSet<TypeDef> Types { get; set; }

  public DbSet<EnumValue> EnumValues { get; set; }

  public DbSet<Pattern> Patterns { get; set; }

  public DbSet<UnionMember> UnionMembers { get; set; }

  public DbSet<ListItem> ListItems { get; set; }

  public DbSet<Attribute> Attributes { get; set; }

  public DbSet<AttributeGroup> AttributeGroups { get; set; }

  public DbSet<AttributeGroupRef> AttributeGroupRefs { get; set; }

  public DbSet<Particle> Particles { get; set; }

  public DbSet<Group> Groups { get; set; }

  public Elements Elements
  {
    get
    {
      if (_Elements == null)
      {
        _Elements = new Elements(Particles);
      }

      return _Elements;
    }
  }
  private Elements? _Elements;

  public Dictionary<string, SchemaFile> FilesDictionary { get; set; } = null!;

  public Dictionary<string, Namespace> NamespaceDictionary { get; set; } = null!;

  public GroupRefs SchemaGroupRefs
  {
    get
    {
      if (_SchemaGroupRefs == null)
      {
        _SchemaGroupRefs = new GroupRefs(Particles);
      }

      return _SchemaGroupRefs;
    }
  }
  private GroupRefs? _SchemaGroupRefs;

  public string DbFilename { get; }

  public XmlSchemaDbContext(string dbFilename)
  {
    DbFilename = dbFilename;
    Database.EnsureCreated();
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseJet(@$"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={DbFilename};");
    //optionsBuilder.EnableSensitiveDataLogging(true);
    //optionsBuilder.LogTo(message => Console.WriteLine(message));
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<UsedNamespace>()
      .HasKey(e => new { SchemaFileId = e.FileId, e.NamespaceId });

    modelBuilder.Entity<UsedNamespace>()
      .HasOne(e => e.SchemaFile)
      .WithMany(e => e.UsedNamespaces)
      .HasForeignKey(e => e.FileId);

    modelBuilder.Entity<UsedNamespace>()
      .HasOne(e => e.SchemaNamespace)
      .WithMany()
      .HasForeignKey(e => e.NamespaceId);

    modelBuilder.Entity<TypeDef>()
      .Property(type => type.IsComplex)
      .HasColumnType("bit");

    modelBuilder.Entity<TypeDef>()
      .HasDiscriminator<bool>("IsComplex")
      .HasValue<SimpleType>(false)
      .HasValue<ComplexType>(true);

    modelBuilder.Entity<TypeDef>()
      .HasOne(e => e.Namespace)
      .WithMany(e => e.Types)
      .HasForeignKey(e => e.NamespaceId);

    modelBuilder.Entity<TypeDef>()
      .HasOne(e => e.BaseTypeNamespace)
      .WithMany()
      .HasForeignKey(e => e.BaseNamespaceId);


    modelBuilder.Entity<TypeDef>()
      .HasOne(e => e.BaseType)
      .WithMany()
      .HasForeignKey(e => e.BaseTypeId);

    modelBuilder.Entity<EnumValue>()
      .HasOne(item => item.OwnerType)
      .WithMany(subItem => subItem.EnumValues)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<Particle>()
      .HasDiscriminator<ParticleType>("ParticleType")
      .HasValue<Any>(ParticleType.Any)
      .HasValue<Element>(ParticleType.Element)
      .HasValue<GroupRef>(ParticleType.GroupRef)
      .HasValue<All>(ParticleType.All)
      .HasValue<Choice>(ParticleType.Choice)
      .HasValue<Sequence>(ParticleType.Sequence);

    modelBuilder.Entity<Particle>()
      .Property("ParticleType").HasColumnType("byte");

    modelBuilder.Entity<Element>()
      .Property(e => e.Name)
      .HasColumnName("Name");

    modelBuilder.Entity<GroupRef>()
      .Property(e => e.RefName)
      .HasColumnName("Name");

    modelBuilder.Entity<Element>()
      .Property(e => e.RefNamespaceId)
      .HasColumnName("RefNamespaceId");

    modelBuilder.Entity<GroupRef>()
      .Property(e => e.RefNamespaceId)
      .HasColumnName("RefNamespaceId");

    modelBuilder.Entity<Particle>()
      .HasOne(p => p.ParentComplexType)
      .WithMany()
      .HasForeignKey(p => p.ComplexTypeId)
      .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<Particle>()
        .HasOne(p => p.ParentGroup)
        .WithMany() // Assuming SchemaGroup has a collection of Particles
        .HasForeignKey(p => p.GroupId)
        .OnDelete(DeleteBehavior.Restrict);

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

  }

  public void LoadFiles()
  {
    FilesDictionary = SchemaFiles.ToDictionary(file => file.FileName);
    NamespaceDictionary = Namespaces.ToDictionary(ns => ns.Url ?? "");

    SchemaFiles.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (SchemaFile file in args.NewItems!)
        {
          FilesDictionary.Add(file.FileName, file);
        }
      }
    };

    Namespaces.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Namespace ns in args.NewItems!)
        {
          NamespaceDictionary.Add(ns.Url, ns);
        }
      }
    };
  }

  public void LoadNamespaces()
  {
    //DisplayMessageEnabled = true;
    foreach (var ns in Namespaces
               .Include(ns => ns.Types)
            )
    {
      ns.TypesDictionary = ns.Types.ToDictionary(type => type.Name, type => type);
    }

    Types.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (TypeDef type in args.NewItems!)
        {
          NamespaceDictionary[type.Namespace.Url].TypesDictionary.Add(type.Name, type);
        }
      }
    };

    foreach (var simpleType in Types.OfType<SimpleType>().Include(type => type.EnumValues))
    {
      //simpleType.PatternsDictionary = simpleType.Patterns.ToDictionary(pattern => pattern.Value);
      simpleType.EnumValuesDictionary = simpleType.EnumValues.ToDictionary(enumValue => enumValue.Name);
      //simpleType.ListItemsDictionary = simpleType.ListItems.ToDictionary(listItem => listItem.Value);
      //simpleType.UnionMembersDictionary = simpleType.UnionMembers.ToDictionary(unionMember => unionMember.MemberType.Name);
    }
    //else if (type is ComplexType complexType)
    //{
    //  //complexType.AttributesDictionary = complexType.Attributes.ToDictionary(attr => attr.Name);
    //  //complexType.AttributeGroupRefsDictionary = complexType.AttributeGroupRefs.ToDictionary(attrGroupRef => attrGroupRef.RefName);
    //  //complexType.ParticlesDictionary = complexType.Particles.ToDictionary(particle => particle.Name);
    //}



    EnumValues.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (EnumValue enumValue in args.NewItems!)
        {
          (NamespaceDictionary[enumValue.OwnerType.Namespace.Url].TypesDictionary[enumValue.OwnerType.Name] as SimpleType)?.EnumValuesDictionary.Add(enumValue.Name, enumValue);
        }
      }
    };

    //Properties.Local.CollectionChanged += (sender, args) =>
    //{
    //  if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
    //  {
    //    foreach (Property prop in args.NewItems!)
    //    {
    //      NamespaceDictionary[prop.OwnerType.Namespace.Name].TypesDictionary[prop.OwnerType.Name].PropertiesDictionary.Add(prop.Name, prop);
    //    }
    //  }
    //};
  }
}
