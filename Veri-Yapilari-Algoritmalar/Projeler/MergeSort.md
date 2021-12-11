# Merge Sort

```
[16,21,11,8,12,22]
```

##### Soru 1) Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.

```
														[16,21,11,8,12,22]
                                     [16,21,11]									 [8,12,22]					Aşama 1
                                     
                               [16]             [21,11]  					[8]				[12,22]			Aşama 2
                               
                               [16] 		 [21]     [11]					[8]			 [12]	  [22]		Aşama 3
                          
                          	   [16]  			[11,21]						[8]				[12,22]			Aşama 4
                          	   
                          	   		 [11,16,21]									  [8,12,22]					Aşama 5								
                                         				[8,11,12,16,21,22]									Aşama 6
```

##### Soru 2) Big-O gösterimini yapınız.

```
Her aşamada O(n) gelir.
n = 2^x
logn = x
O(n logn)
```

# Binary Search

##### Soru 1) Aşağıdaki dizinin Binary-Search-Tree aşamalarını yazınız.

```
[7,5,1,8,3,6,0,9,4,2]
```

```
Öncelikle diziyi sıralayalım
[0,1,2,3,4,5,6,7,8,9]
Root Değer = 5
Dengeli bir dağılım için;
Sağında = 7
Solunda = 3
											 5
										 3		 7	
									  2	   4   6   8
								   1				 9
								 0			
```