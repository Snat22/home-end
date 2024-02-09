﻿namespace Task4;

public class Product
{
    string _name;
    double _price;
    int _quantity;

    public Product(string name,double price,int quantity)
    {
            _name = name;
            _price = price;
            _quantity = quantity;        
    }

    public string PrintProduct()
    {
        return $"{_name}: price {_price}: {_quantity} pcs";
    }
}
