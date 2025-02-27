﻿#define FLYWEIGHTS
namespace Flyweight;

internal class FlyweightFactory
{
    private List<Flyweight> _flyweights = new List<Flyweight>();

    public Brand GetBrand(string name, string logoUrl)
    {
#if FLYWEIGHTS
        Brand? brand = _flyweights.OfType<Brand>().FirstOrDefault(b => b.LogoUrl == logoUrl);
#else
        Brand? brand = null;
#endif
        if (brand == null)
        {
            brand = new Brand { Name = name, LogoUrl = logoUrl };
            _flyweights.Add(brand);
            brand.Download();
        }
        else
        {
            // Create Flyweight
            brand = new Brand { 
                Name = name, 
                LogoUrl = logoUrl, 
                Logo = brand.Logo };
        }
        return brand;
    }
    public Product GetProduct(string brand, string type, string logoUrl)
    {
#if FLYWEIGHTS
        Product? product = _flyweights.OfType<Product>().FirstOrDefault(p=>p.LogoUrl == logoUrl);
#else
        Product? product = null;
#endif
        if (product == null)
        {
            product = new Product { Brand = brand, Type = type, LogoUrl = logoUrl };
            _flyweights.Add(product);
            product.Download();
        }
        else
        {
            product = new Product
            {
                Brand = brand,
                Type = type,
                LogoUrl = logoUrl,
                Logo = product.Logo
            };
        }
        return product;
    }
}
