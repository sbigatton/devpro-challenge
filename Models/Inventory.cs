namespace DevProChallenge.Models;

public class Inventory
{
    private List<Product> _products;

    public void AddProduct(Product product){
        _products ??= [];
        _products.Add(product);
    }

    public List<Product> GetSortedProducts(string sort_key, bool ascending = true){
        var sortedProducts = sort_key.ToLower() switch
        {
            "name" => ascending ? 
                        _products.OrderBy(p => p.Name) : 
                        _products.OrderByDescending(p => p.Name),
            "price" => ascending ? 
                        _products.OrderBy(p => p.Price) : 
                        _products.OrderByDescending(p => p.Price),
            "stock" => ascending ? 
                        _products.OrderBy(p => p.Stock) : 
                        _products.OrderByDescending(p => p.Stock),
            _ => throw new Exception($"'{sort_key}' sorting products not found.")
        };
        
        return sortedProducts.ToList();
    }
} 