SELECT description, title, length, rental_rate,replacement_cost FROM film
WHERE length >60 AND length <75 AND rental_rate = 0.99 AND replacement_cost = 12.99 OR replacement_cost = 29.99;


SELECT first_name,last_name FROM customer
WHERE first_name = 'Mary';


SELECT * FROM film
where length <50 AND rental_rate = 2.99 OR NOT rental_rate = 4.99;


  film tablosunda bulunan title ve description sütunlarındaki verileri sıralayınız.
 film tablosunda bulunan tüm sütunlardaki verileri film uzunluğu (length) 60 dan büyük VE 75 ten küçük olma koşullarıyla sıralayınız.
 film tablosunda bulunan tüm sütunlardaki verileri rental_rate 0.99 VE replacement_cost 12.99 VEYA 28.99 olma koşullarıyla sıralayınız.
 customer tablosunda bulunan first_name sütunundaki değeri 'Mary' olan müşterinin last_name sütunundaki değeri nedir?
 film tablosundaki uzunluğu(length) 50 ten büyük OLMAYIP aynı zamanda rental_rate değeri 2.99 veya 4.99 OLMAYAN verileri sıralayınız.