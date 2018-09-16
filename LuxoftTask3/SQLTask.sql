--a) List of Clients which have an order with order_sum > 50 
Select Distinct c.* from Orders o with(nolock)
Join Clients c with(nolock) on c.client_Id=o.client_id
Where o.order_sum > 50

--b) clients,whose total sum of orders exceeds 100
Select c.client_Id,c.client_name,SUM(o.order_sum) OrderSum from Orders o with(nolock)
Join Clients c with(nolock) on c.client_Id=o.client_id
Group by c.client_Id,c.client_name
Having SUM(o.order_sum) > 100