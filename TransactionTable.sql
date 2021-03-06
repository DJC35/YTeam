DROP TABLE BANK_TRANSACTION

CREATE TABLE BANK_TRANSACTION (
TRANSACTION_NUM			INTEGER			NOT NULL,
TRANSACTION_DATE		DATE			NOT NULL,
TRANSACTION_AMOUNT		DECIMAL(12,2)	NOT NULL,
TRANSACTION_TYPE		VARCHAR(10)		NOT NULL,
ACCOUNT_ID				INTEGER			NOT NULL
primary key (TRANSACTION_NUM)
FOREIGN KEY (ACCOUNT_ID) REFERENCES ACCOUNT(ACCOUNT_ID));

INSERT INTO BANK_TRANSACTION VALUES(1,'2017-02-16', 264.54, 'Deposit', 1);

select * from BANK_TRANSACTION;