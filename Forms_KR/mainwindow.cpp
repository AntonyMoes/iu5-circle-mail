#include "mainwindow.h"
#include "ui_mainwindow.h"

#include <string>
#include <QMainWindow>
#include <QGridLayout>
#include <QWidget>
#include <QString>

using namespace std;

message::message(QWidget *parent, std::string send_address, std::string send_letter):
    QPushButton(parent){
    this->send_address = send_address;
    this->send_letter = send_letter;
}
message::~message()
{

}

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    wLetter_send = new Letter_send();
    connect(wLetter_send, &Letter_send::open_send_letter, this, &MainWindow::show);

}

MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::on_scrollArea_customContextMenuRequested(const QPoint &pos)
{

}

void MainWindow::on_pushButton_2_clicked()
{
    wLetter_send->show();
}

void MainWindow::push_messege()
{
    message *button = (message*)sender();

    ui->lineEdit->setText(QString::fromStdString(button->send_address));
    ui->textEdit->setText(QString::fromStdString(button->send_letter));

}

//Пришло письмо (для тестов) --- ПРИШЛО ПИСЬМО
void MainWindow::on_pushButton_3_clicked()
{
    string pismo = "Письмо от: ";



    message *button = new message(this, "lenkaDEA@gmail.com", "cho ia delau?"); //Приходящую информацию сюда! 2арг. от кого, 3арг. письмо

    button->setText(QString::fromStdString(pismo + button->send_address));
  //  ui->verticalLayout->addWidget(button);

    connect(button, SIGNAL(clicked()), this, SLOT(push_messege()));


    if (ui->scrollAreaWidgetContents->layout()==nullptr){
        QVBoxLayout *Layout = new QVBoxLayout;
        ui->scrollAreaWidgetContents->setLayout(Layout);

    }


    ui->scrollAreaWidgetContents->layout()->addWidget(button);




}

void MainWindow::on_pushButton_4_clicked()
{
//    char b = 'b';
//    string send_letter = "HELP2";

//    QPushButton *button1 = new QPushButton(this);
//    button1->setText("Письмо от1: " + b);
//    ui->scrollArea->add(button1);
}

void MainWindow::on_pushButton_3_pressed()
{
////    string send_adress = "lenka@gmail.com";
////    char a = 'a';
////    string send_letter = "HELP";

////    QPushButton *button = new QPushButton(this);
////    button->setText("Письмо от: " + a);
////    ui->scrollArea->setWidget(button);
}



void MainWindow::on_lineEdit_textChanged(const QString &arg1)
{


}

void MainWindow::on_pushButton_clicked()
{

    wLetter_send->sender_adderess = ui->lineEdit->text().toStdString();
    wLetter_send->show();
}
