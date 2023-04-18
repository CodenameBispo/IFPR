/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.exemploswingmvc.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ConnectionFactory {
    private Connection connection;
    private static String db_host;
    private static String db_name;
    private static String db_timeZone;
    private static String db_user;
    private static String db_pass;
    
    public ConnectionFactory(){
        db_host = "jdbc:mysql://localhost:3306/";
        db_name = "exemplomvc";
        db_timeZone = "?useTimezone=true&serverTimezone=UTC";
        db_user = "root";
        db_pass = "";              
    }
    
    public Connection getConnection() {
        try{
            DriverManager.registerDriver(new com.mysql.cj.jdbc.Driver());
            Connection connection = DriverManager.getConnection
                    (db_host + db_name + db_timeZone, db_user, db_pass);
            return connection;
        } catch(SQLException e) {
            throw new RuntimeException (e);
        }
    }

}

