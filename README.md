# 🔐 RSA Encryption & Decryption in C#

This project is a simple yet complete implementation of the **RSA cryptosystem** in **C#**, demonstrating how public-key encryption works under the hood using number theory concepts like **prime numbers**, **modular arithmetic**, **modular inverse**, and **Euler’s totient function**.

---

## 📘 Overview

The RSA algorithm is one of the most widely used public-key cryptography systems.  
This project performs the following steps:

1. Takes two prime numbers `p` and `q`.  
2. Calculates:
   - \( n = p \times q \)
   - \( \phi(n) = (p-1) \times (q-1) \)
3. Verifies that `e` (public exponent) is coprime with `φ(n)`.
4. Computes the private key `d` using the modular inverse of `e (mod φ(n))`.
5. Encrypts a message `m` using:
6. Decrypts the ciphertext `c` using:

---

## ⚙️ Features

- Compute **public** and **private** keys  
- Encrypt and decrypt integer messages  
- Uses **BigInteger** for handling large numbers  
- Implements **GCD**, **ModInverse**, and **ModPow** from scratch  
- Console-based and easy to test  

---

## 🧩 Code Structure
RSA.cs
│
├── Encription(BigInteger p, BigInteger q, BigInteger e, BigInteger m)
│ ├── Calculates n, φ(n)
│ ├── Finds d (private key)
│ ├── Encrypts message m
│ └── Decrypts the ciphertext
│
├── ModInverse(BigInteger a, BigInteger m)
│ └── Finds modular inverse using Extended Euclidean Algorithm
│
├── Decryption(BigInteger c, BigInteger d, BigInteger n)
│ └── Performs modular exponentiation for decryption
│
└── GCD(BigInteger a, BigInteger b)
└── Finds greatest common divisor

---

## 🚀 Example Usage

```csharp
using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        RSA rsa = new RSA();
        
        BigInteger p = 61;     // Example prime 1
        BigInteger q = 53;     // Example prime 2
        BigInteger e = 17;     // Public exponent
        BigInteger m = 65;     // Message to encrypt (integer)
        
        rsa.Encription(p, q, e, m);
    }
}
```
## 🧮 Sample Output
```
n = p* q = 3233
φ(n) phi => : 3120
d*e mod phi => 1
private key: d => 2753
cipher text = 2790
decrypte: 65
```
## 🛠️ Requirements

.NET 6.0 or later

System.Numerics namespace (for BigInteger support)

## 📚 Notes

This implementation is for educational purposes only.
It’s not optimized or secure enough for real-world cryptography.

Works best with small prime numbers to visualize the RSA steps.

You can extend it to:

Generate random large primes

Support text-to-number encoding

Implement digital signatures


⚠️ This project is for educational purposes only. It does not aim to break or bypass security systems.
