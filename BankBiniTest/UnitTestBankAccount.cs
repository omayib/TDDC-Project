using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankBini;

namespace BankBiniTest
{
    [TestClass]
    public class UnitTestBankAccount
    {
        [TestMethod]
        public void Test_Bank_Account_Berhasil_Dibuat()
        {
            BankAccount bankAccount = new BankAccount("Rini", 10000);
            Assert.AreEqual("Rini", bankAccount.getName());
            Assert.AreEqual(10000, bankAccount.getBalance());
        }
        [TestMethod]
        public void Test_Bank_Account_Saldo_Bertambah()
        {
            BankAccount bankAccount = new BankAccount("Rini", 10000);
            bankAccount.addBalance(500);
            Assert.AreEqual(10500, bankAccount.getBalance());
        }
        [TestMethod]
        public void Test_Bank_Account_Saldo_Berkurang()
        {
            BankAccount bankAccount = new BankAccount("Rini", 10000);
            bankAccount.withDraw(2500);
            Assert.AreEqual(7500, bankAccount.getBalance());
        }
        [TestMethod]
        public void Test_Bank_Account_Saldo_Tidak_Mencukupi()
        {
            BankAccount bankAccount = new BankAccount("Rini", 10000);
            Assert.ThrowsException<System.ArgumentException>(
                () => bankAccount.withDraw(50000)
                );
        }
    }
}

/*
 
            BankAccount bankAccount = new BankAccount("Rini",10000);
            Assert.AreEqual("Rini", bankAccount.getName());
            Assert.AreEqual("10000", bankAccount.getBalance());
     */
